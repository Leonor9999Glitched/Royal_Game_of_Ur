using System;

namespace Royal_Game_of_Ur
{
    public class Rules
    {
        public void ShowRules()
        {
            Console.WriteLine("1 - Para jogar este jogo são precisos dois jogadores.");
            Console.WriteLine("2 - O objectivo do jogo é ser o primeiro a colocar as sete peças que há por jogador, no final do tabuleiro.");
            Console.WriteLine("3 - Cada jogador tem quatro dados com apenas duas casas que valem um valor.");
            Console.WriteLine("4 - Cada jogador pode tirar um máximo de quatro casas por turno.");
            Console.WriteLine("5 - Se o jogador não tirar nenhuma casa, perde a vez.");
            Console.WriteLine("6 - Há zonas de perigo e zonas seguras.");
            Console.WriteLine("7 - Cada jogador tem a sua própria zona segura e o oponente não pode entrar na zona segura do outro jogador.");
            Console.WriteLine("8 - Se, na zona de perigo, uma peça cair sobre a outra, a que ficar por debaixo, regressa ao inicio do tabuleiro.");
            Console.WriteLine("9 - Cada peça que chegue ao final do tabuleiro, é um ponto.");
            Console.WriteLine("10 - Ganha aquele que conseguir sete pontos primeiro.");
            Console.WriteLine("11 - Há umas casas com uma flor lá desenha (ou um caracter especial).");
            Console.WriteLine("12 - Se uma peça cair lá, jogador ganha um turno extra.");
            Console.WriteLine("13 - Não se pude comer uma peça que esteja na casa da flor (a casa da flor é uma zona segura).");
        }
    }
}