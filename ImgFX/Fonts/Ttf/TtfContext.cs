using System.Text;

namespace ImgFX.Fonts.Ttf;

public class TtfContext
{
    public TtfHeader FontHeader { get; set; }
    public Dictionary<string, TableDirectoryEntry> TableDirectory { get; set; }
    public TtfNameTable FontNameTable { get; set; } = new();

    public TtfContext(string filePath)
    {
        using var reader = new BinaryReader(File.OpenRead(filePath));
        FontHeader = new TtfHeader
        {
            SfntVersion = reader.ReadUInt32(),
            NumTables = reader.ReadUInt16(),
            SearchRange = reader.ReadUInt16(),
            EntrySelector = reader.ReadUInt16(),
            RangeShift = reader.ReadUInt16()
        };

        TableDirectory = new Dictionary<string, TableDirectoryEntry>();
        for (int i = 0; i < FontHeader.NumTables; i++)
        {
            var entry = new TableDirectoryEntry
            {
                Tag = Encoding.ASCII.GetString(reader.ReadBytes(4)),
                CheckSum = reader.ReadUInt32(),
                Offset = reader.ReadUInt32(),
                Length = reader.ReadUInt32()
            };

            TableDirectory.Add(entry.Tag, entry);
        }

        if (TableDirectory.ContainsKey("name"))
        {
            var nameTableEntry = TableDirectory["name"];

            reader.BaseStream.Seek(nameTableEntry.Offset, SeekOrigin.Begin);

            FontNameTable = new TtfNameTable
            {
                Format = reader.ReadUInt16(),
                Count = reader.ReadUInt16(),
                StringOffset = reader.ReadUInt16(),
                NameRecords = new()
            };

            for (int i = 0; i < FontNameTable.Count; i++)
            {
                var nameRecord = new TtfNameRecord
                {
                    PlatformID = reader.ReadUInt16(),
                    EncodingID = reader.ReadUInt16(),
                    LanguageID = reader.ReadUInt16(),
                    NameID = reader.ReadUInt16(),
                    Length = reader.ReadUInt16(),
                    Offset = reader.ReadUInt16()
                };

                var currentPosition = reader.BaseStream.Position;

                reader.BaseStream.Seek(nameTableEntry.Offset + FontNameTable.StringOffset + nameRecord.Offset, SeekOrigin.Begin);

                nameRecord.Value = Encoding.UTF8.GetString(reader.ReadBytes(nameRecord.Length));

                reader.BaseStream.Position = currentPosition;

                FontNameTable.NameRecords.Add(nameRecord);
            }
        }
    }
}
