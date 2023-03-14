class KeyValuePair<T, V>
{
    public T Key { get; set; }
    public V Value { get; set; }
    public KeyValuePair(T key, V value)
    {
        Key = key;
        Value = value;
    }
}