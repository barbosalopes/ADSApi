using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;



namespace ADSApi.List.Util
{
    public class PersonGenerator
    {
        public static async Task<Person> GetPersonAsync()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            HttpClient client = new HttpClient(handler);
            
            HttpResponseMessage response = await client.GetAsync("https://api.namefake.com/portuguese-brazil/random/");
            response.EnsureSuccessStatusCode();

            Person person;
            string responseBodyAsText = await response.Content.ReadAsStringAsync();
            person = JsonConvert.DeserializeObject<Person>(responseBodyAsText);
            return person;
        }
    }
}
