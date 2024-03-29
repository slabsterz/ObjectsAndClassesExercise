namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                string[] inputLine = Console.ReadLine().Split();
                string trainerName = inputLine[0];

                if (trainerName == "Tournament")
                {
                    string command = Console.ReadLine();

                    if (command == "End")
                    {
                        break;
                    }                                
                }

                string pokemonName = inputLine[1];
                string pokemonElement = inputLine[2];
                int pokemonHealth = int.Parse(inputLine[3]);                

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName);
              
                trainer.PokemonCollection.Add(pokemon);
            }
        }
    }
}
