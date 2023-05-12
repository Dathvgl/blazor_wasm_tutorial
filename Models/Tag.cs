using System.Text.Json.Serialization;

public class TagAttribute
{
    [JsonPropertyName("name")]
    public Dictionary<string, string>? Name { get; set; }
    [JsonPropertyName("description")]
    public Dictionary<string, string>? Description { get; set; }
    [JsonPropertyName("group")]
    public string? Group { get; set; }
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

public class TagMangadex
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("attributes")]
    public TagAttribute? Attributes { get; set; }
    [JsonPropertyName("relationships")]
    public IList<RelationshipMangadex>? Relationships { get; set; }
}

public class TagsResponse : ResultMangadex
{
    [JsonPropertyName("data")]
    public IList<TagMangadex>? Data { get; set; }
}
