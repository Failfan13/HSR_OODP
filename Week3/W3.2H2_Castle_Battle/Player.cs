public class Player {

  public string Name;
  public int MaxHP;
  public int CurrentHP;
  public int Strength;
  public int PlayerLevel = 1;
  public int Experience;
  public  Player(string name, int baseHP, int baseStrength) {
    Name = name;
    MaxHP = CurrentHP = baseHP;
    Strength = baseStrength;
  }

  public bool IsAlive() {
    if (CurrentHP <= 0)
      return false;
    return true;
  }

  public int GetLevel() {
    return this.PlayerLevel;
  }

  public void AddExp(int expAmount) {
    Experience += expAmount;
    if (Experience >= World.ExperienceChart[PlayerLevel -1]) {
      this.PlayerLevel++;
    }

  }
  public void Attack(Monster fightMonster) {
    fightMonster.HP -= this.Strength;
    if (fightMonster.HP <= 0) {
      this.AddExp(fightMonster.Experience);
    }
  }

  public void TakeDamage(int damageAmount) {
    this.CurrentHP -= damageAmount;
  }
}