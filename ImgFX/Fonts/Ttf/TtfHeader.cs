namespace ImgFX.Fonts.Ttf;

public record TtfHeader
{
    public uint SfntVersion { get; init; }
    public ushort NumTables { get; init; }
    public ushort SearchRange { get; init; }
    public ushort EntrySelector { get; init; }
    public ushort RangeShift { get; init; }
}
