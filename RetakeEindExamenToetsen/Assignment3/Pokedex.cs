public static class Pokedex
{
    public static void PrintTotalEvolutions(List<Pokemon> pokemonList)
    {
        // Complete the following code segment with the definition of print action
        Action<Pokemon> printAction = p => Console.WriteLine(p.Name + " has " + p.Evolutions.Count() + " evolutions.");

        // call the method PrintEvolutionCount here
        PrintEvolutionCount(pokemonList, printAction);
    }

    public static void PrintEvolutionCount(List<Pokemon> pokemonList, Action<Pokemon> act)
    {
        if (pokemonList == null) return;

        foreach (Pokemon poke in pokemonList)
        {
            if (poke.Evolutions != null)
            {
                act(poke);
                PrintEvolutionCount(poke.Evolutions, act);
            }
        }
    }
}
