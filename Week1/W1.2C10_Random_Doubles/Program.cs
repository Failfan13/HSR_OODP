class Program {
    static void Main() {
        int attack = 50, bossHP = 1000, hit;
        double critChance = 0.33;

        Random rnd = new Random();
        
        while (bossHP > 0) {
            Console.Write($"Boss HP: {bossHP}\nDamage: ");
            hit = (Math.Round(rnd.NextDouble(), 2) == critChance ? attack*2 : attack);
            bossHP = bossHP - hit;
            Console.WriteLine($"{hit}");
        };

        Console.WriteLine("Boss defeated");
    }
}