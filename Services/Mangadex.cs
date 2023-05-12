using System.Net;
using System.Text.Json;

public class MangadexService : HttpClient
{
    public Dictionary<string, string>? Iso6391 { get; set; }

    public MangadexService()
    {
        BaseAddress = new Uri("https://api.mangadex.org");
    }

    public async Task Init(Uri? localHost)
    {
        var client = new HttpClient();
        client.BaseAddress = localHost;
        
        var response = await client.GetAsync("json/iso6391.json");
        if (response.StatusCode == HttpStatusCode.OK)
        {
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(content);
            Iso6391 = data;
        } else {
            Iso6391 = new Dictionary<string, string>()
            {
                { "en", "US" }
            };
        }

    }
}
