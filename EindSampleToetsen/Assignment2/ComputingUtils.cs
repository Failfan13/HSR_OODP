public static class ComputingUtils
{
    public static (string, int)[]? ComputePortions<T>(Tuple<T, double>[][] jArr)
    {
        if (jArr == null) return null;

        int maxLength = jArr.MaxBy(a => a.Count()).Count();

        var res = new (string, int)[maxLength];

        for (int i = 0; i < jArr.Length; i++)
        {
            for (int j = 0; j < jArr[i].Length; j++)
            {
                res[j].Item1 = jArr[i][j].Item1.ToString();
                res[j].Item2++;
            }
        }

        return res;
    }

    public static Tuple<string, double>[] ComputeTotals<T>(Tuple<T, double>[][] jArr)
    {
        if (jArr == null) return null;

        var bill = new Tuple<string, double>[jArr.Length];

        for (int i = 0; i < jArr.Length; i++)
        {
            var tmpString = "";
            var tmpTotal = 0.0;

            for (int j = 0; j < jArr[i].Length; j++)
            {
                tmpString += jArr[i][j].Item1.ToString() + "::";
                tmpTotal += jArr[i][j].Item2;
            }
            bill[i] = Tuple.Create(tmpString, tmpTotal);
        }
        return bill;
    }
}