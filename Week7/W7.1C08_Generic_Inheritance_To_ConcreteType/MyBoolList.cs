class MyBoolList : MyGenericList<bool>
{
    public MyBoolList(List<bool> list)
        : base(list) { }

    public override bool Combine()
    {
        if (base.Elems.Any(x => x != base.Elems[0]))
        {
            return false;
        }
        return true;
    }
}