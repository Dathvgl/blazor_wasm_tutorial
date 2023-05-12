using System.Text.Json.Serialization;

public class AggregateChapter
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("count")]
    public int? Count { get; set; }
    [JsonPropertyName("chapter")]
    public string? Chapter { get; set; }
    [JsonPropertyName("others")]
    public IList<string>? Others { get; set; }
}

public class AggregateVolume
{
    [JsonPropertyName("volume")]
    public string? Volume { get; set; }
    [JsonPropertyName("count")]
    public int? Count { get; set; }
    [JsonPropertyName("chapters")]
    public Dictionary<string, AggregateChapter>? Chapters { get; set; }
}

public class AggregateResponse : ResultMangadex
{
    [JsonPropertyName("volumes")]
    public Dictionary<string, AggregateVolume>? Volumes { get; set; }
}
