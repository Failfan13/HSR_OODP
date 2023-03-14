class Program
{
    public static void Main()
    {
        List<object> BillList = new()
        {
            new ElectricityBill(50, "John Smith"),
            new ElectricityBill( 75, "Jane Doe"),
            new GasBill(100, "Bob Johnson", false),
            new GasBill(125, "John Doe", true),
        };

        int totalBill = 0;
        foreach (var bill in BillList)
        {
            Console.WriteLine(((Bill)bill).GetDescription());
            totalBill += (int)((Bill)bill).Amount;
        }
        Console.WriteLine($"Total amount: {totalBill}");
    }
}