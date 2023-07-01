public static class JaggedUtils
{
    public static DataEntryPair<T1, T2>[] FromTuple2DataEntryPairArray<T1, T2>(Tuple<T1, T2>[] tupArr)
    {
        var arrEntry = new DataEntryPair<T1, T2>[tupArr.Length];

        for (int i = 0; i < tupArr.Length; i++)
        {
            arrEntry[i] = new DataEntryPair<T1, T2>(tupArr[i].Item1, tupArr[i].Item2);
        }

        return arrEntry;
    }

    public static string[,] ToMultidimensionalArray<T>(T[][] mArr)
    {
        if (mArr == null) return null;

        var maxLength = 0;

        for (int i = 0; i < mArr.Length; i++)
        {
            if (mArr[i].Count() > maxLength) maxLength = mArr[i].Count();
        }

        var multiArr = new string[mArr.Length, maxLength];

        for (int i = 0; i < mArr.Length; i++)
        {
            for (int j = 0; j < mArr[i].Length; j++)
            {
                multiArr[i, j] = mArr[i][j].ToString();
            }
        }

        return multiArr;
    }
}