namespace ImgFX.Fonts.Ttf;

public record TableDirectoryEntry
{
    public string Tag { get; init; } = string.Empty;
    public uint CheckSum { get; init; }
    public uint Offset { get; init; }
    public uint Length { get; init; }
}
