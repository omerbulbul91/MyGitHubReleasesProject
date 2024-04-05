
//deneme
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        try
        {
            // GitHub API'sinden son release bilgisini sorgulama
            string owner = "dotnet"; // GitHub'da araştırmak istediğiniz kullanıcı veya organizasyon adı
            string repo = "runtime"; // İlgili GitHub deposu adı
            string url = $"https://api.github.com/repos/{owner}/{repo}/releases/latest";

            // GitHub API, User-Agent başlığını gerektirir
            client.DefaultRequestHeaders.Add("User-Agent", "C# console program");

            // API'den gelen yanıtı al
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Yanıtı JSON olarak ekrana yazdır
            Console.WriteLine(responseBody);

            // JSON yanıtını daha anlaşılır bir formata dönüştürmek için (opsiyonel)
            var releaseInfo = JsonConvert.DeserializeObject<dynamic>(responseBody);
            Console.WriteLine($"Son release adı: {releaseInfo.name}");
            Console.WriteLine($"Yayınlanma tarihi: {releaseInfo.published_at}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}
