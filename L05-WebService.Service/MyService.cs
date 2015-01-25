using L05_WebService.Service.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace L05_WebService.Service
{
    
    public class MyService
    {
        Service1Client service;
        public MyService()
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            var address = new EndpointAddress("http://testmyws.azurewebsites.net/Service1.svc");
            service = new Service1Client(binding, address);
        }

        public Task<string> GetData(int value)
        {
            var task = new TaskCompletionSource<string>();
            service.GetDataCompleted += (sender, e) =>
            {
                if (e.Cancelled)
                    task.TrySetCanceled();
                else if (e.Error != null)
                    task.TrySetException(e.Error);
                else
                    task.TrySetResult(e.Result);
            };
            service.GetDataAsync(value);
            return task.Task;
        }
    }
}
