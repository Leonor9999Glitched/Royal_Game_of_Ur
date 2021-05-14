using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void ShowPlayers(IEnumerable<Player> players);

        Player AskForPlayer();

        int AskForMinimumScore();
    }
}
