using System;

namespace Royal_Game_of_Ur
{
    public class Rules
    {
        public void ShowRules()
        {
            Console.WriteLine("1 - São precisos duas pessoas para jogar este jogo.");
            Console.WriteLine("2 - Cada pessoa tem 7 peças e 4 quatro dados.");
            Console.WriteLine("3 - Os dados são triangulares e duas pontas pintadas. Se sair uma ponta pintada, significa que o jogo pode andar uma casa.");
            Console.WriteLine("4 - Um jogador pode andar até 4 casas por turno, dependendo de casas pontadas que cairem.");
            Console.WriteLine("5 - Se não sair nenhuma ponta pintada, o jogador não avança.");
            Console.WriteLine("6 - Há zonas de perigo e há zonas seguras no tabuleiro.");
            Console.WriteLine("7 - Se na zona de perigo, uma pela aterrar assim de outra, a peça que está por debaixo, regressa ao inicio do tabuleiro.");
            Console.WriteLine("8 - Um jogador cair em cima das casas especiais, pode jogar novamente.");
            Console.WriteLine("8 - Ganha o jogador que conseguir levar todas as 7 peças até ao final do tabuleiro.");
        }
    }
}