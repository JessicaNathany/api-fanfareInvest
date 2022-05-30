using System.Net.Http.Headers;

namespace api_fanfareInvest.api.Data
{
    public static  class ClientConnection
    {
        public static string ClientResult(string url)
        {
            using HttpClient? client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            return result;
        }
    }
}
