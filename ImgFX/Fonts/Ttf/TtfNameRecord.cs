namespace ImgFX.Fonts.Ttf;

public record TtfNameRecord
{
    public ushort PlatformID { get; init; }
    public ushort EncodingID { get; init; }
    public ushort LanguageID { get; init; }
    public ushort NameID { get; init; }
    public ushort Length { get; init; }
    public ushort Offset { get; init; }
    public string Value { get; set; } = string.Empty;
}
