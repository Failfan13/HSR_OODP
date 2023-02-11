public class Artifact {
    public double Rarity;
    public double Condition;
    public Artifact(double rare, double cond) {
        Rarity = rare;
        Condition = cond;
    }

    public double GetValue() {
        return (Rarity * Condition);
    }

    public string Appraise() {
        return $"Value: {GetValue()}";
    }

    public bool isEqualTo(Artifact objArtifact) {
        if (objArtifact == null) {
            return false;
        } else if (objArtifact.Rarity == this.Rarity && objArtifact.Condition == this.Condition) {
            return true;
        } else {
            return false;
        }
    }
}