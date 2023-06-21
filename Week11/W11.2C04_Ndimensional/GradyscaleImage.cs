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

    public void AdjustBrightness(double factor)
    {
        for (int i = 0; i < PixelData.GetLength(0); i++)
            for (int j = 0; j < PixelData.GetLength(1); j++)
                PixelData[i, j] = (int)(PixelData[i, j] * factor);
    }
}