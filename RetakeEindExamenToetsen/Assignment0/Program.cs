using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        // switch (args[1])
        // {
        //     case "IRECHARGEABLE": TestIRechargeable(); return;
        //     case "ICAMERA": TestICamera(); return;
        //     case "ABSTRACT": TestAbstractClassElectricDevice(); return;
        //     case "SMARTPHONE": TestSmartphone(); return;
        //     case "SMARTPHONEFUN": TestSmartphoneFunctionality(); return;
        //     default: throw new ArgumentException();
        // }
        TestIRechargeable();
        TestICamera();
        TestAbstractClassElectricDevice();
        TestSmartphone();
        TestSmartphoneFunctionality();
    }

    static void TestAbstractClassElectricDevice()
    {
        Console.WriteLine("ElectricDevice cannot be instantiated: "
            + typeof(ElectricDevice).IsAbstract);
        Type abstractType = typeof(ElectricDevice);
        Console.WriteLine("Method TurnOn has no implementation: "
            + abstractType.GetMethod("TurnOn").IsAbstract);
        Console.WriteLine("Method TurnOff has no implementation: "
            + abstractType.GetMethod("TurnOff").IsAbstract);
        Console.WriteLine("Method Display has no implementation: "
            + abstractType.GetMethod("Display").IsAbstract);
        Console.WriteLine(
            "Property Name Encapsulation: " +
            TestAccessModifierProperty("ElectricDevice", "Name", "Public", null));
        Console.WriteLine(
            "Property Voltage Encapsulation: " +
            TestAccessModifierProperty("ElectricDevice", "Voltage", "Public", "Public"));
        Console.WriteLine(
            "Property IsOn Encapsulation: " +
            TestAccessModifierProperty("ElectricDevice", "IsOn", "Public", "Family"));

        ElectricDevice phone = new Smartphone("Samsung Galaxy s21", "5G");
        Console.WriteLine("Name: " + phone.Name);
        Console.WriteLine("IsOn: " + phone.IsOn);
    }

    static void TestIRechargeable()
    {
        // Test whether IRechargeable is an interface
        Type interfaceType = typeof(IRechargeable);
        Console.WriteLine("IRechargeable is an interface: " + interfaceType.IsInterface);

        // Test whether ElectricDevice implements IRechargeable
        Type classType = typeof(ElectricDevice);
        bool implementsInterface = classType.GetInterfaces().Contains(interfaceType);
        Console.WriteLine("ElectricDevice implements the interface: " + implementsInterface);

        IRechargeable phone = new Smartphone("Samsung Galaxy j5", "4G");
        phone.Recharge();
        Console.WriteLine(phone.BatteryLevel);
        Console.WriteLine(
            "Property BatteryLevel Encapsulation: " +
            TestAccessModifierProperty("IRechargeable", "BatteryLevel", "Public", "Public"));
    }

    static void TestICamera()
    {
        // Test whether ICamera is an interface
        Type interfaceType = typeof(ICamera);
        Console.WriteLine("ICamera is an interface: " + interfaceType.IsInterface);
        // Test whether Smartphone implements ICamera
        ICamera phone = new Smartphone("iPhone15", "6G");
        phone.TakePhoto();
    }

    static void TestSmartphone()
    {
        // Testing Encapsulation    
        Console.WriteLine(
            "Property Generation Encapsulation: " +
            TestAccessModifierProperty("Smartphone", "Generation", "Public", null));
    }

    static void TestSmartphoneFunctionality()
    {
        Console.WriteLine("********* CREATING SMARTPHONE ***********");
        Smartphone phone = new Smartphone("Nokia 3310", "3G");
        phone.Display();
        phone.TakePhoto();
        Console.WriteLine("********* TURNING ON SMARTPHONE ***********");
        phone.TurnOn();
        Console.WriteLine("********* RECHARGING SMARTPHONE ***********");
        phone.BatteryLevel = 101;
        phone.Display();
        phone.BatteryLevel = -1;
        phone.Display();
        phone.Recharge();
        phone.Display();
        Console.WriteLine("********* TURNING ON SMARTPHONE ***********");
        phone.TurnOn();
        phone.TakePhoto();
        phone.TakePhoto();
        phone.Display();
        Console.WriteLine("********* TURNING OFF SMARTPHONE ***********");
        phone.TurnOff();
        Console.WriteLine("Phone.IsOn: " + phone.IsOn);
        phone.Recharge();
        phone.Display();
    }

    static string TestAccessModifierProperty(string cls, string property, string getTest, string setTest)
    {
        var p = Type.GetType(cls).GetProperty(property,
          BindingFlags.NonPublic |
          BindingFlags.Public |
          BindingFlags.Instance);
        if (p == null)
            return $"Property not found: {property}";

        var flag = false;
        if (getTest != null)
        {
            flag = p.CanRead;
            if (getTest == "Public")
                flag = p.GetMethod.IsPublic;
            else if (getTest == "Family")
                flag = p.GetMethod.IsFamily;
            else if (getTest == "Private")
                flag = p.GetMethod.IsPrivate;
            else
                flag = false;
        }
        if (setTest != null)
        {
            flag = flag && p.CanWrite;
            if (setTest == "Public")
                flag = flag && p.SetMethod.IsPublic;
            else if (setTest == "Family")
                flag = flag && p.SetMethod.IsFamily;
            else if (setTest == "Private")
                flag = flag && p.SetMethod.IsPrivate;
            else
                flag = false;
        }
        return flag == true ? "Correct!" : "Incorrect.";
    }
}