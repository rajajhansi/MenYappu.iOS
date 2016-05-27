using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MenYappu
{
    public static class MenYappuRestServiceWrapper
    {
        public static async Task<string> GetSampleSeerAsync(string uri)
        {
            var parseResult = string.Empty;
            if (string.IsNullOrEmpty(parseResult))
            {
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        var jsonData = string.Empty;
                        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                        HttpResponseMessage response = null;
                        response = await httpClient.PostAsync(new Uri(uri), content);

                        if (response.IsSuccessStatusCode)
                        {
                            parseResult = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(parseResult);
                        }

                        return parseResult;
                    }
                    catch (Exception e)
                    {
                        parseResult = e.Message;
                    }
                }
            }
            return parseResult;
        }

        public static async Task<string> CalculateMathiraiAsync(string uri, string inputData)
        {
            var parseResult = string.Empty;
            if (string.IsNullOrEmpty(parseResult))
            {
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        //var jsonData = JsonConvert.SerializeObject(inputData); ;
                        var content = new StringContent(inputData, Encoding.UTF8, "application/json");

                        HttpResponseMessage response = null;
                        response = await httpClient.PostAsync(new Uri(uri), content);

                        if (response.IsSuccessStatusCode)
                        {
                            parseResult = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(parseResult);
                        }

                        return parseResult;
                    }
                    catch (Exception e)
                    {
                        parseResult = e.Message;
                    }
                }
            }
            return parseResult;
        }
    }
}
