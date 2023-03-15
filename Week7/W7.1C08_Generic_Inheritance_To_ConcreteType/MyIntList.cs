class MyIntList : MyGenericList<int>
{
    public MyIntList(List<int> list)
        : base(list) { }

    public override int Combine()
    {
        return base.Elems.Sum(x => Convert.ToInt32(x));
    }
}