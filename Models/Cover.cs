using System.Text.Json.Serialization;

public class CoverAttribute
{
    [JsonPropertyName("volume")]
    public string? Volume { get; set; }
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }
    [JsonPropertyName("version")]
    public int? Version { get; set; }
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

public class CoverMangadex
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("attributes")]
    public CoverAttribute? Attributes { get; set; }
    [JsonPropertyName("relationships")]
    public IList<RelationshipMangadex>? Relationships { get; set; }
}

public class CoverResponse : ResultMangadex
{
    [JsonPropertyName("data")]
    public CoverMangadex? Data { get; set; }
}
