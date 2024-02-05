namespace ImgFX.Jpeg;

/// <summary>
/// <b>Warning</b><br />
/// This was not tested, and was AI-generated! Use with caution.
/// </summary>
public class JpegContext
{
    public JpegHeader Header { get; set; }
    public JpegData Data { get; set; }

    public JpegContext(byte[] jpegBytes)
    {
        Header = new JpegHeader(
            Array.Empty<byte>(),
            Array.Empty<byte>(),
            Array.Empty<byte>(),
            Array.Empty<byte>(),
            Array.Empty<byte>(),
            Array.Empty<byte>()
        );
        Data = new JpegData(
            Array.Empty<byte>(),
            Array.Empty<byte>()
        );

        int pos = 0;

        byte[] ReadSegment()
        {
            byte[] marker = new byte[2];
            Array.Copy(jpegBytes, pos, marker, 0, 2);
            pos += 2;

            byte[] lengthBytes = new byte[2];
            Array.Copy(jpegBytes, pos, lengthBytes, 0, 2);
            pos += 2;
            int length = (lengthBytes[0] << 8) + lengthBytes[1];

            byte[] data = new byte[length - 2];
            Array.Copy(jpegBytes, pos, data, 0, length - 2);
            pos += length - 2;

            return data;
        }

        while (pos < jpegBytes.Length)
        {
            byte[] marker = new byte[2];
            Array.Copy(jpegBytes, pos, marker, 0, 2);

            switch (BitConverter.ToString(marker))
            {
                case "FF-D8":
                    Header.Soi = marker;
                    pos += 2;
                    break;
                case "FF-E0":
                    Header.App0 = ReadSegment();
                    break;
                case "FF-DB":
                    Header.Dqt = ReadSegment();
                    break;
                case "FF-C0":
                    Header.Sof0 = ReadSegment();
                    break;
                case "FF-C4":
                    Header.Dht = ReadSegment();
                    break;
                case "FF-DA":
                    Header.Sos = ReadSegment();
                    break;
                case "FF-D9":
                    Data.Eoi = marker;
                    pos += 2;
                    break;
                default:
                    throw new Exception("Invalid or unsupported JPEG marker: " + BitConverter.ToString(marker));
            }

            if (BitConverter.ToString(marker) == "FF-D9")
            {
                Data.ScanData = new byte[jpegBytes.Length - pos];
                Array.Copy(jpegBytes, pos, Data.ScanData, 0, jpegBytes.Length - pos);
                break;
            }
        }
    }

    public Rgb.Rgb[,] ToRgbArray()
    {
        int width = (Header.Sof0[3] << 8) + Header.Sof0[4];
        int height = (Header.Sof0[1] << 8) + Header.Sof0[2];

        Rgb.Rgb[,] rgbArray = new Rgb.Rgb[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                byte pixel = Data.ScanData[y * width + x];

                Rgb.Rgb rgb = new(pixel, pixel, pixel);

                rgbArray[y, x] = rgb;
            }
        }

        return rgbArray;
    }
}

