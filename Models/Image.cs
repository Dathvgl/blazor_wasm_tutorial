using System.Text.Json.Serialization;

public class ImageChapter
{
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    [JsonPropertyName("data")]
    public IList<string>? Data { get; set; }
    [JsonPropertyName("dataSaver")]
    public IList<string>? DataSaver { get; set; }
}

public class ImageResponse : ResultMangadex
{
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }
    [JsonPropertyName("chapter")]
    public ImageChapter? Chapter { get; set; }
}
