public class GrayscaleImage
{
    public int Height { get; }
    public int Width { get; }

    public int[,] PixelData { get; }

    public GrayscaleImage(int height, int width)
    {
        //Set Width, Height and PixelData
        Height = height;
        Width = width;
        PixelData = new int[height, width];
    }

    public GrayscaleImage(int[,] pixelData)
    {
        //Set Width, Height and PixelData
        Height = pixelData.GetLength(0);
        Width = pixelData.GetLength(1);
        PixelData = pixelData;
    }
}