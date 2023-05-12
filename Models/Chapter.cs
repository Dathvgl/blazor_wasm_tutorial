using System.Text.Json.Serialization;

public class ChapterAttribute
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("volume")]
    public string? Volume { get; set; }
    [JsonPropertyName("chapter")]
    public string? Chapter { get; set; }
    [JsonPropertyName("pages")]
    public int? Pages { get; set; }
    [JsonPropertyName("translatedLanguage")]
    public string? TranslatedLanguage { get; set; }
    [JsonPropertyName("uploader")]
    public string? Uploader { get; set; }
    [JsonPropertyName("externalUrl")]
    public string? ExternalUrl { get; set; }
    [JsonPropertyName("version")]
    public int? Version { get; set; }
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
    [JsonPropertyName("publishAt")]
    public string? PublishAt { get; set; }
    [JsonPropertyName("readableAt")]
    public string? ReadableAt { get; set; }
}

public class ChapterMangadex
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("attributes")]
    public ChapterAttribute? Attributes { get; set; }
    [JsonPropertyName("relationships")]
    public IList<RelationshipMangadex>? Relationships { get; set; }
}

public class ChaptersResponse : ResultMangadex
{
    [JsonPropertyName("data")]
    public IList<ChapterMangadex>? Data { get; set; }
}

public class ChapterResponse : ResultMangadex
{
    [JsonPropertyName("data")]
    public ChapterMangadex? Data { get; set; }
}
