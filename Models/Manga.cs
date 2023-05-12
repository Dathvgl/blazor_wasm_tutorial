using System.Text.Json.Serialization;

public class MangaAttribute
{
    [JsonPropertyName("title")]
    public Dictionary<string, string>? Title { get; set; }
    [JsonPropertyName("altTitles")]
    public IList<Dictionary<string, string>>? AltTitles { get; set; }
    [JsonPropertyName("description")]
    public Dictionary<string, string>? Description { get; set; }
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }
    [JsonPropertyName("links")]
    public Dictionary<string, string>? Links { get; set; }
    [JsonPropertyName("originalLanguage")]
    public string? OriginalLanguage { get; set; }
    [JsonPropertyName("lastVolume")]
    public string? LastVolume { get; set; }
    [JsonPropertyName("lastChapter")]
    public string? LastChapter { get; set; }
    [JsonPropertyName("publicationDemographic")]
    public string? PublicationDemographic { get; set; }
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    [JsonPropertyName("year")]
    public int? Year { get; set; }
    [JsonPropertyName("contentRating")]
    public string? ContentRating { get; set; }
    [JsonPropertyName("chapterNumbersResetOnNewVolume")]
    public bool? ChapterNumbersResetOnNewVolume { get; set; }
    [JsonPropertyName("latestUploadedChapter")]
    public string? LatestUploadedChapter { get; set; }
    [JsonPropertyName("tags")]
    public IList<TagMangadex>? Tags { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("version")]
    public int? Version { get; set; }
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

public class MangaMangadex
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("attributes")]
    public MangaAttribute? Attributes { get; set; }
    [JsonPropertyName("relationships")]
    public IList<RelationshipMangadex>? Relationships { get; set; }
}

public class MangasResponse : ResultMangadex
{
    [JsonPropertyName("data")]
    public IList<MangaMangadex>? Data { get; set; }
}

public class MangaResponse : ResultMangadex
{
    [JsonPropertyName("data")]
    public MangaMangadex? Data { get; set; }
}
