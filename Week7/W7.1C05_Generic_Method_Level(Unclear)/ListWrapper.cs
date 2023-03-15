class ListWrapper<T>
{
    private List<T> _myLst = new();

    public void Add(T para)
    {
        _myLst.Add(para);
    }

    public T Get(int index)
    {
        return _myLst[index];
    }
    public int Count()
    {
        return _myLst.Count();
    }

    public int HighestCount(ListWrapper<T> list)
    {
        return list.Count();
    }
}