public static class TextUtils
{
    public static Tuple<string[], string[]> CreateSentences<T>(T[][] jArr)
    {
        if (jArr == null) return null;

        var maxHor = 0;

        for (int i = 0; i < jArr.Length; i++)
        {
            if (jArr[i].Length > maxHor) maxHor = jArr[i].Length;
        }

        string[] hori = new string[jArr.Length];
        string[] verti = new string[maxHor];

        for (int i = 0; i < jArr.Length; i++)
        {
            for (int j = 0; j < jArr[i].Length; j++)
            {
                verti[j] += jArr[i][j].ToString() + " ";
                hori[i] += jArr[i][j].ToString() + " ";
            }
        }

        //return new Tuple<string[], string[]>().Create(hori, verti);
        return Tuple.Create<string[], string[]>(hori, verti);
    }
}