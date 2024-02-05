namespace ImgFX.Jpeg;

public class JpegData
{
    public byte[] ScanData { get; set; }
    public byte[] Eoi { get; set; }

    public JpegData(byte[] scanData, byte[] eoi)
    {
        ScanData = scanData;
        Eoi = eoi;
    }
}
