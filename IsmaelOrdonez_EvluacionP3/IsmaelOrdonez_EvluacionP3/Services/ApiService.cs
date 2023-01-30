using Newtonsoft.Json;
using IsmaelOrdonez_EvluacionP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmaelOrdonez_EvluacionP3.Services
{
    public class ApiService
    {
        public ApiService() { }
        private string apoServiceURL;
        public string ApoServiceURL
        {
            get
            {
                if (string.IsNullOrEmpty(apoServiceURL))
                {
                    apoServiceURL = "https://nekos.best/api/v2/";
                }
                return apoServiceURL;
            }
            set => apoServiceURL = value;
        }

        private static HttpClient client = new HttpClient();
        public HttpClient GetClient()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "aplication/json");
            }
            return client;
        }

        public async Task<Api.Root> GetImage(string name, int quantity)
        {
            Api.Root dto = null;
            HttpResponseMessage response = null;
            string requesURL = $"{ApoServiceURL}search?query={name}&type=2&amount={quantity}";
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requesURL);
                HttpClient client = GetClient();
                response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dto = JsonConvert.DeserializeObject<Api.Root>(json);
                }
            }

            catch (Exception ex)
            {
                string mensaje = ex.Message;
                throw;
            }
            return dto;
        }
    }
}
