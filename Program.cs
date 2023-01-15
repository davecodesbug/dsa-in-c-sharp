using System.Collections;

namespace DSA
{
    internal abstract class Code
    {
        private static void Main()
        {
            ArrayList games = new ArrayList();

            games.Add("Red Dead Redemption");
            games.Add("Call of Duty");
            games.Add("Elden Ring");
            games.Add("PUBG");
            games.Insert(0, "DOOMSLAYER");
            games.Sort();

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine(games.Count);
        }
    }
}
