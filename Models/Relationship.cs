using System.Text.Json.Serialization;

public class RelationshipMangadex
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("related")]
    public string? Related { get; set; }
    [JsonPropertyName("attributes")]
    public object? Attributes { get; set; }
}
