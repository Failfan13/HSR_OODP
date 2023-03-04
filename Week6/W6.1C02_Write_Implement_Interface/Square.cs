class Square : IResizable, IDrawable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    void IResizable.Resize(double scale)
    {
        Size = (Int32)((double)Size * scale);
    }

    void IDrawable.Draw()
    {
        string square = "";
        for (var i = 0; i < Size; i++)
        {
            for (var j = 0; j < Size; j++)
            {
                square += "*";
            }
            square += "\n";
        }
        Console.WriteLine(square);
    }
}