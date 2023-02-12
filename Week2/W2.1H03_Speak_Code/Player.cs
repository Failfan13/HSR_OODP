public class Player {
    public string Name;
    public int HealthPoints = 100;
    public int Power;

    public Player(string name, int power) {
        Name = name;
        Power = power;
    }

    public bool IsAlive() {
        return (HealthPoints > 0 ? true : false);
    }

    public bool TakeDamage(int demagePT) {
        if (HealthPoints - demagePT < 0) {
            HealthPoints = 0;
            return false;
        } else {
            HealthPoints = HealthPoints - demagePT;
            return true;
        }
    }
}