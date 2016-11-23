using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Configuration;
using TestingMachineLearning.Models;
using Newtonsoft.Json;

namespace TestingMachineLearning

{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeRetrainModel().Wait();
        }
        static async Task InvokeRequestResponseService()
        {
            using (HttpClient client = new HttpClient())
            {
                var scoreRequest = new ScoreRequest();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ConfigurationManager.AppSettings["AzureApiKey"]);
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["AzureClientUrlML"]);

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest.ColumnsParameters);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Failed with status code: {0}", response.StatusCode);
                }
            }
        }

        static async Task InvokeRetrainModel()
        {

            var resourceLocations = new ResourceLocations()
            {
                Resources = new ResourceLocation[]
                {
                    new ResourceLocation()
                    {
                        Name ="Iris Classification [trained model]",
                        Location = new AzureBlobDataReference()
                        {
                            BaseLocation ="",
                            RelativeLocation  = "",
                            SasBlobToken  = ""
                        }
                    }
               
                }
            };

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ConfigurationManager.AppSettings["UpdateApiKey"]);
                using (HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), ConfigurationManager.AppSettings["UpdateClientUrl"]))
                {

                    request.Content = new StringContent(JsonConvert.SerializeObject(resourceLocations), System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Result: {0}", result);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Failed with status code: {0}", response.StatusCode);
                    }
                }
            }
        }
    }
}
