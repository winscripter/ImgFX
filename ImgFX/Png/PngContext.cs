using System.Text;
using System.Buffers.Binary;

namespace ImgFX.Png;

/// <summary>
/// Represents information about a Portable Network
/// Graphics (PNG) image format.
/// </summary>
public class PngContext
{
    private readonly byte[] _data;
    private readonly PngChunk _ihdr;
    private readonly List<PngChunk> _chunks;

    /// <summary>
    /// Signature, header, or magic of the PNG file. E.g.,
    /// the very first 8 bytes, which tell any tool or program
    /// that the file format is truly PNG.
    /// </summary>
    public static readonly byte[] Magic =
    {
        137, 80, 78, 71, 13, 10, 26, 10
    };

    /// <summary>
    /// Initializes a new instance of <see cref="PngContext" />
    /// </summary>
    /// <param name="data">
    /// File content of a PNG file in bytes.
    /// Try <see cref="File.ReadAllBytes(string)" />
    /// </param>
    public PngContext(byte[] data)
    {
        _data = data;

        var chunks = BeginReading();
        _ihdr = chunks[0];
        chunks.RemoveAt(0);
        _chunks = chunks;
    }

    private List<PngChunk> BeginReading()
    {
        if (!_data.Take(8).SequenceEqual(Magic))
        {
            throw new PngException("PNG magic (e.g. signature) is incorrect");
        }

        List<PngChunk> chunks = new();

        int index = 8;
        while (index < _data.Length)
        {
            uint length = BitConverter.ToUInt32(_data.Skip(index).Take(4).Reverse().ToArray(), 0);
            index += 4;

            string type = Encoding.ASCII.GetString(_data, index, 4);
            index += 4;

            byte[] data = _data.Skip(index).Take((int)length).ToArray();
            index += (int)length;

            uint crc = BitConverter.ToUInt32(_data.Skip(index).Take(4).Reverse().ToArray(), 0);
            index += 4;

            var chunk = new PngChunk(length, type, data, crc);

            chunks.Add(chunk);
        }

        return chunks;
    }

    /// <summary>
    /// The IHDR (Image HeaDeR) chunk of the Portable Network
    /// Graphics (PNG) image format, which describes common
    /// information about this image (f.e. height and width of
    /// this image in pixels). This is the first chunk of any
    /// PNG file, and must be present for the image file to
    /// be valid.
    /// </summary>
    public PngChunk IHDR
    {
        get
        {
            return _ihdr;
        }
    }

    /// <summary>
    /// All chunks of a PNG file, except the first chunk - IHDR. To
    /// get the IHDR chunk, use <see cref="IHDR" /> instead.
    /// </summary>
    public List<PngChunk> Chunks
    {
        get
        {
            return _chunks;
        }
    }

    /// <summary>
    /// Width of this image in pixels
    /// </summary>
    public uint ImageWidth
    {
        get
        {
            uint size = BitConverter.ToUInt32(
                new byte[]
                {
                    IHDR.Data[0],
                    IHDR.Data[1],
                    IHDR.Data[2],
                    IHDR.Data[3]
                }
            );

            return BinaryPrimitives.ReverseEndianness(size);
        }
    }

    /// <summary>
    /// Height of this image in pixels
    /// </summary>
    public uint ImageHeight
    {
        get
        {
            uint size = BitConverter.ToUInt32(
                new byte[]
                {
                    IHDR.Data[4],
                    IHDR.Data[5],
                    IHDR.Data[6],
                    IHDR.Data[7]
                }
            );

            return BinaryPrimitives.ReverseEndianness(size);
        }
    }
}
