using System;

namespace Royal_Game_of_Ur
{
    class Program
    {

        //Onde tudo começa
        static void Main(string[] args)
        {
            string escolha;
            Rules rules = new Rules();
            Game game = new Game();
            
            Console.WriteLine("Bem-vindos ao Royal Game of Ur!");
            Console.WriteLine("São precisos dois jogadores para este jogo.");
            Console.WriteLine("Mas primeiro, é preciso ver o que o jogador deseja fazer.");
            Console.WriteLine("1 - Jogar o jogo");
            Console.WriteLine("2 - Regras do jogo");
            Console.WriteLine("3 - Sair do programa");

            escolha = Console.ReadLine();

            // Permitir ao jogador escolher o que quer fazer
            do
            {
                if (escolha == "1")
                {
                    Console.WriteLine("Vamos jogar!!!");
                    game.Play();
                    escolha = Console.ReadLine();
                }
                else if (escolha == "2")
                {
                    rules.ShowRules();
                    escolha = Console.ReadLine();
                }
            } while (escolha != "3");

            Console.WriteLine("Vejo-te em breve!!!");
        }
    }
}
