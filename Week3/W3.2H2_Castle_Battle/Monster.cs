public class Monster {

    public string Name;
    public int HP;
    public int Strength;
    public int Experience;

    public Monster(string name, int hP, int strength, int exp) {
        Name = name;
        HP = hP;
        Strength = strength;
        Experience = exp;
    }

  public bool IsAlive() {
    if (this.HP <= 0)
      return false;
    return true;
  }

  public void Attack(Player fightPlayer) {
    fightPlayer.TakeDamage(this.Strength);
  }
}