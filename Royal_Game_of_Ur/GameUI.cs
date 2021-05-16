using System;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class GameUI : IView
    {
        private Controller controller;
        // private List<Player> list;

        public GameUI(Controller controller) //, List<Player> list)
        {
            this.controller = controller;
            // this.list = list;
        }

        //Menu
        public int MainMenu()
        {
            Console.WriteLine("------------------------- Menu --------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-----       Bem-vindos ao Royal Game of Ur!     ---------");
            Console.WriteLine("---    São precisos dois jogadores para este jogo.   ----");
            Console.WriteLine("------------       Escolha uma opção       --------------");
            Console.WriteLine("---------------------------V-----------------------------");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("------------             1. Play           --------------");
            Console.WriteLine("------------         2. Show Players       --------------");
            Console.WriteLine("------------          3. Show Scores       --------------");
            Console.WriteLine("------------             0. Exit           --------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        //O jogador escolhe a opcção errada
        public void InvalidOption()
        {
            Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        public void ShowPlayers(IEnumerable<Player> players)
        {
            Console.WriteLine();
            foreach (Player p in players)
            {
                Console.WriteLine($"-> {p}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }

        // Criação do jogaor
        public Player AskForPlayer()
        {
            string name;
            int score = 0;

            Console.WriteLine();
            Console.WriteLine("Insert player data");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.Write("Name > ");
            name = Console.ReadLine();
            Console.Write("Score > " + score);

            return new Player(name, score); 
        }

        // Score minimo
        public int AskForMinimumScore()
        {
            Console.WriteLine();
            Console.Write("Minimum score? > ");
            return int.Parse(Console.ReadLine());
        }
    }
}
