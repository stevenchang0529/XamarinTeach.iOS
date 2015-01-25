using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace L06_WebAPI.Share
{
    public class APIService
    {
        public  static string Address = "http://testmyapi.azurewebsites.net/api/values/";

        public async Task <MyClass> GetJson()
        {
            WebClient request = new WebClient();
            var result = await request.DownloadStringTaskAsync(new Uri(Address));
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
