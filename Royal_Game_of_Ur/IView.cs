using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public interface IView
    {
        // Mostra algumas acções que o jogo terá
        int MainMenu();

        void InvalidOption();

        void ShowPlayers(IEnumerable<Player> players);

        Player AskForPlayer();

        int AskForMinimumScore();
    }
}
