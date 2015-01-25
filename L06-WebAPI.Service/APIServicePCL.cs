using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace L06_WebAPI.Service
{
    public class APIServicePCL
    {
        public static string Address = "http://testmyapi.azurewebsites.net/api/values/";

        public async Task<MyClass> GetJson()
        {
            HttpClient service = new HttpClient();
            var result = await service.GetStringAsync(Address);
            return JsonConvert.DeserializeObject<MyClass>(result);
        }

    }

    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Work { get; set; }
    }
}
