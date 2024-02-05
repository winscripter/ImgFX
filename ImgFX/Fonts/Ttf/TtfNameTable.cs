namespace ImgFX.Fonts.Ttf;

public record TtfNameTable
{
    public ushort Format { get; init; }
    public ushort Count { get; init; }
    public ushort StringOffset { get; init; }
    public List<TtfNameRecord> NameRecords { get; set; } = new();
}
