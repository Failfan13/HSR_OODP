public class DataEntryPair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public DataEntryPair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }

    public static bool operator ==(DataEntryPair<T1, T2> left, DataEntryPair<T1, T2> right)
    {
        if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            return false;
        return (left.First).Equals(right.First) && (left.Second).Equals(right.Second);
    }

    public static bool operator !=(DataEntryPair<T1, T2> left, DataEntryPair<T1, T2> right) =>
              !(left == right);

    public override string ToString() => $"[{First}; {Second}]";
}