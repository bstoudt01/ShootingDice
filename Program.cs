using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            UpperHalfPlayer player1 = new UpperHalfPlayer();
            player1.Name = "Bob";
            //player1.Taunt = "Hey... They Call me Robert Paulsen and you are a LOOOOSSSSEEERRRR";

            OneHigherPlayer player2 = new OneHigherPlayer();
            player2.Name = "Sue";

            player1.Play(player2);
            Console.WriteLine("-------------------");

            HumanPlayer player3 = new HumanPlayer();
            player3.Name = "Bert";

            player3.Play(player1);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer player4 = new CreativeSmackTalkingPlayer();
            player4.Name = "Jimbo";

            Player player5 = new Player();
            player5.Name = "Drew";

            player4.Play(player5);
            Console.WriteLine("-------------------");

            LargeDicePlayer large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}