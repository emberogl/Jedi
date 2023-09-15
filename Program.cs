namespace Jedi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Opgave 1
            Dictionary<string, int>? dictionary = new Dictionary<string, int>()
            #endregion Opgave 1
            {
            #region Opgave 2
                {"Emre", 19 },
                {"Jesus", 2023 }
            };
            Console.WriteLine($"{dictionary.First().Key}, {dictionary.First().Value}\n");
            #endregion Opgave 2

            #region Opgave 3
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };
            characters.Remove("Han");
            #endregion Opgave 3

            #region Opgave 4
            foreach (var character in characters )
            {
                Console.WriteLine($"{character.Key} = {character.Value}");
            }
            #endregion Opgave 4
        }
    }
}