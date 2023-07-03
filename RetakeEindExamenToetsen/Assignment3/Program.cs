public class Program
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "TestPrintTotalEvolutions":
                TestPrintTotalEvolutions();
                break;
            // CodeTester class
            case "CodeTesterLambda":
                CodeTester.TestLambda();
                break;
            default:
                Console.WriteLine("No test found");
                break;
        }
    }
    public static void TestPrintTotalEvolutions()
    {
        // Create a sample Pokedex with Pokemon and their evolutions
        List<Pokemon> PokemonList = new() {
                new Pokemon {
                    Name = "Charmander",
                    Evolutions = new List<Pokemon> {
                        new Pokemon {
                            Name = "Charmeleon",
                            Evolutions = new List<Pokemon> {
                                new Pokemon {
                                    Name = "Charizard",
                                    Evolutions = new List<Pokemon> {
                                        new Pokemon { Name = "Mega Charizard X" },
                                        new Pokemon { Name = "Mega Charizard Y" }
                                    }
                                }
                            }
                        },
                    }
                },
                new Pokemon {
                    Name = "Bulbasaur",
                    Evolutions = new List<Pokemon> {
                        new Pokemon {
                            Name = "Ivysaur",
                            Evolutions = new List<Pokemon> {
                                new Pokemon { Name = "Venusaur" }
                            }
                        }
                    }
                },
                new Pokemon {
                    Name = "Squirtle",
                    Evolutions = new List<Pokemon> {
                        new Pokemon {
                            Name = "Wartortle",
                            Evolutions = new List<Pokemon> {
                                new Pokemon { Name = "Blastoise" }
                            }
                        }
                    }
                }
            };


        // Count and print the total number of evolutions
        Pokedex.PrintTotalEvolutions(PokemonList);
    }
}