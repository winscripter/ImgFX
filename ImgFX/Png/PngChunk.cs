namespace ImgFX.Png;

/// <summary>
/// Represents a single chunk of the PNG image format.
/// </summary>
/// <param name="Length">
/// Length of the chunk data
/// </param>
/// <param name="Type">
/// 4 letters representing the type of this chunk. If this
/// is equal to IHDR, <see cref="Data"/> must contain two
/// values: Height and Width, respectively.
/// </param>
/// <param name="Data">
/// Data about this chunk. Might contain pixels, or, if this is
/// the IHDR chunk, contains height and width values, respectively.
/// </param>
/// <param name="Crc">
/// CRC of this PNG chunk
/// </param>
public record PngChunk(
    uint Length,
    string Type,
    byte[] Data,
    uint Crc
);
