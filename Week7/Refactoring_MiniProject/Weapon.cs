public class Weapon : Item, IDamagePoints
{
    private int _minimumDamage;
    private int _maximumDamage;
    public int MinimumDamage
    {
        get => _minimumDamage;
        set
        {
            _minimumDamage = (value < 0 || value > 50 ? 0 : value);
        }
    }
    public int MaximumDamage
    {
        get => _maximumDamage;
        set => _maximumDamage = value switch
        {
            >= 0 and <= 50 => value,
            < 0 => 0,
            > 50 => 50,
        };
    }

    public Weapon(int iD, string name, string namePlural, int minimumDamage, int maximumDamage)
        : base(iD, name, namePlural)
    {
        MinimumDamage = minimumDamage;
        MaximumDamage = maximumDamage;
    }

    public string Info()
    {
        return Name + ":\nMinimum damage: " + MinimumDamage + ":\nMaximum damage: " + MaximumDamage;
    }
}