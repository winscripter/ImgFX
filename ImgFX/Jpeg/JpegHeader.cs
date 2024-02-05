namespace ImgFX.Jpeg;

public class JpegHeader
{
    public byte[] Soi { get; set; }
    public byte[] App0 { get; set; }
    public byte[] Dqt { get; set; }
    public byte[] Sof0 { get; set; }
    public byte[] Dht { get; set; }
    public byte[] Sos { get; set; }

    public JpegHeader(
        byte[] soi,
        byte[] app0,
        byte[] dqt,
        byte[] sof0,
        byte[] dht,
        byte[] sos
    )
    {
        Soi = soi;
        App0 = app0;
        Dqt = dqt;
        Sof0 = sof0;
        Dht = dht;
        Sos = sos;
    }
}