public class Range
{
    public int Start { get; }
    public int End { get; }
    public int Step { get; }

    public Range(int start, int end, int step)
    {
        Start = start;
        End = end;
        Step = step;
    }

    public IEnumerable<int> Next()
    {
        for (int i = Start; i < End; i += Step)
        {
            yield return i;
        }
    }
}