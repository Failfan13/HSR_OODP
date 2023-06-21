static class DnaStrand
{
    public static string ComplementaryStrand(string DNA)
    {
        Dictionary<char, char> comp = new()
        {
            {'A', 'T'},
            {'C', 'G'},
            {'G', 'C'},
            {'T', 'A'}
        };

        char[] newDna = DNA.ToCharArray();

        for (int i = 0; i < newDna.Length; i++)
        {
            newDna[i] = comp[newDna[i]];
        }

        Array.Reverse(newDna);

        return string.Join("", newDna);
    }

    public static bool IsValidDnaStrand(string DNA)
    {
        char[] ableDna = new char[4] { 'A', 'C', 'G', 'T' };

        if (DNA.Length < 4) return false;
        if (DNA.Any(c => !ableDna.Contains(c)))
            return false;
        return true;
    }

    public static string Transcribe(string DNA) => DNA.Replace('T', 'U');

    public static int HammingDistance(string DNA1, string DNA2)
    {
        if (DNA1.Length != DNA2.Length) return -1;

        int hamming = 0;

        for (int i = 0; i < DNA1.Length; i++)
            if (DNA1[i] != DNA2[i])
                hamming++;

        return hamming;
    }
}