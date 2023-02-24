class Player {
    public string Name;
    public int Points;
    public int Skill;
    public int Intelligence;
    public int Knowledge;
    public Player(string name, int skill, int intelligence, int knowledge) {
        this.Name = name;
        this.Skill = skill;
        this.Intelligence = intelligence;
        this.Knowledge = knowledge;
    }
    public void Score() {
        this.Points++;
    }
    public static Player WhoIsWinning(Player p1, Player p2) {
        if(p1.Points > p2.Points)
            return p1;
        else if (p2.Points < p1.Points)
            return p2;
        return null;
    }

}