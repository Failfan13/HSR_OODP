public class Program
{
    static void Main(string[] args)
    {
        // switch (args[1])
        // {
        //     case "IAccount": TestIAccount(); return;
        //     case "IEquatable": TestIEquatable(); return;
        //     case "Inheritance": TestInheritance(); return;
        //     case "IComparable": TestIComparable(); return;
        //     case "Implement": TestImplementIAccount(); return;
        //     case "BankUtils": TestBankUtils(); return;
        //     default: throw new ArgumentException();
        // }
        TestIAccount();
        TestIEquatable();
        TestInheritance();
        TestIComparable();
        TestImplementIAccount();
        TestBankUtils();
    }

    static void TestImplementInterfaces()
    {
        // Test whether the classes have implemented the interfaces.
        // If there is a compilation error here, one or
        // more interfaces have not been implemented.
        IComparable<SavingsAccount<double>> comparableAccount = new SavingsAccount<double>("ABC123", 0.05);
        IEquatable<IAccount> equatableAccount = new BankAccount("ABC123");
        IAccount account = new BankAccount("ABC123");
    }

    static void TestIAccount()
    {
        // Test whether IAccount is an interface and
        // has the correct method and property signatures.
        Type accountType = typeof(IAccount);
        bool isAccountInterface = accountType.IsInterface;
        bool hasAccountAccountNumberProperty = accountType.GetProperty("AccountNumber") != null;
        bool hasAccountBalanceProperty = accountType.GetProperty("Balance") != null;
        bool hasAccountDepositMethod = accountType.GetMethod("Deposit") != null;
        bool hasAccountWithdrawMethod = accountType.GetMethod("Withdraw") != null;

        Console.WriteLine($"IAccount is an interface: {isAccountInterface}");
        Console.WriteLine($"IAccount has the AccountNumber property: {hasAccountAccountNumberProperty}");
        Console.WriteLine($"IAccount has the Balance property: {hasAccountBalanceProperty}");
        Console.WriteLine($"IAccount has the Deposit method: {hasAccountDepositMethod}");
        Console.WriteLine($"IAccount has the Withdraw method: {hasAccountWithdrawMethod}");
    }

    static void TestBankUtils()
    {
        // Test whether BankUtils.ExecuteTransaction uses the
        // 'where' constraint to limit the parameter to IAccounts.
        // If there is a compilation error here,
        // it is not implemented (or not correctly).
        DepositAccount depAccount = new("ABC123", 1000);
        BankUtils.PrintAccountBalance<IAccount>(depAccount);
    }

    static void TestIEquatable()
    {
        // Test whether BankAccount has implemented IEquatable correctly.
        object bankAcc1 = new BankAccount("ABC123"); // Object
        IAccount bankAcc2 = new BankAccount("ABC123");
        IAccount bankAcc3 = new BankAccount("DEF456");
        object savAccount1 = new SavingsAccount<double>("ABC123", 0.05); // Object
        IAccount savAccount2 = new SavingsAccount<double>("GHI789", 0.05);

        bool accEquality1 = bankAcc1.Equals(bankAcc2);
        bool accEquality2 = bankAcc1.Equals(bankAcc3);
        bool accEquality3 = bankAcc1.Equals(savAccount1);
        bool accEquality4 = savAccount1.Equals(bankAcc1);
        bool accEquality5 = savAccount1.Equals(savAccount2);
        bool accEquality6 = savAccount1.Equals(null);
        bool accEquality7 = savAccount1.Equals(new List<int>());

        Console.WriteLine($"Shape equality result 1: {accEquality1}"); // true
        Console.WriteLine($"Shape equality result 2: {accEquality2}"); // false
        Console.WriteLine($"Shape equality result 3: {accEquality3}"); // true
        Console.WriteLine($"Shape equality result 4: {accEquality4}"); // true
        Console.WriteLine($"Shape equality result 5: {accEquality5}"); // false
        Console.WriteLine($"Shape equality result 6: {accEquality6}"); // false
        Console.WriteLine($"Shape equality result 7: {accEquality7}"); // false
    }

    static void TestInheritance()
    {
        // Test whether SavingsAccount inherits from BankAccount.
        bool doesSavingsAccountInherit = typeof(SavingsAccount<double>).BaseType == typeof(BankAccount);
        Console.WriteLine($"SavingsAccount<T> inherits from BankAccount: {doesSavingsAccountInherit}");
    }

    static void TestImplementIAccount()
    {
        // Test whether BankAccount has implemented IAccount correctly.
        IAccount acc = new BankAccount("ABC123");
        Console.WriteLine($"BankAccount AccountNumber: {acc.AccountNumber}");
        Console.WriteLine($"Original Balance: {acc.Balance}");

        Console.WriteLine("\nDepositing and withdrawing...\n");

        acc.Deposit(1000);
        acc.Withdraw(500);
        acc.Deposit(2000);
        acc.Withdraw(1000);

        Console.WriteLine($"BankAccount AccountNumber: {acc.AccountNumber}");
        Console.WriteLine($"New Balance: {acc.Balance}");
    }

    static void TestIComparable()
    {
        // Test whether SavingsAccount has implemented IComparable correctly.
        List<SavingsAccount<double>> savAccountList = new() {
            new SavingsAccount<double>("ABC123", 0.05),
            new SavingsAccount<double>("DEF456", 0.04),
            new SavingsAccount<double>("GHI789", 0.06),
            null,
            new SavingsAccount<double>("JKL234", 0.05),
            new SavingsAccount<double>("MNO234", 0.05),
        };

        savAccountList[0].Deposit(1000);
        savAccountList[1].Deposit(2000);
        savAccountList[2].Deposit(1500);
        savAccountList[4].Deposit(1000);
        savAccountList[5].Deposit(1000);

        Console.WriteLine("Before sorting:");
        PrintSavingsAccountList(savAccountList);

        savAccountList.Sort();
        Console.WriteLine("\nAfter sorting:");
        PrintSavingsAccountList(savAccountList);
    }

    static void PrintSavingsAccountList(List<SavingsAccount<double>> savAccountList)
    {
        foreach (var acc in savAccountList)
        {
            Console.WriteLine(acc == null
                ? "null"
                : $"Balance: {acc.Balance}, Interest rate: {acc.InterestRate}");
        }
    }
}