using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();
            List<string> cards = new List<string>();

            string commandLine = Console.ReadLine();

            while (!commandLine.Contains("JOKER"))
            {
                string[] seggInput = commandLine.Split(':').ToArray();
                string playerName = seggInput[0];
                cards = seggInput[1].Split(',').ToList();

                if (!playersCards.ContainsKey(playerName))
                {
                    playersCards.Add(playerName, new List<string>());
                }

                playersCards[playerName].AddRange(cards);

                commandLine = Console.ReadLine();

            }

            // Still a lot to do>!

        }
    }
}
