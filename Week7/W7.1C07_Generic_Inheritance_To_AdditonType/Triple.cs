class Triple<T1, T2, T3> : Pair<T1, T2>
{
    public T3 Trd { get; private set; }

    public Triple(T1 fst, T2 snd, T3 trd)
        : base(fst, snd)
        => Trd = trd;
}