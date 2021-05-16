using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class Controller
    {
        private List<Player> list;
        private IView view;

        public Controller(List<Player> list)
        {
            this.list = list;
        }

        public void Run(IView view)
        {
            int input;
            this.view = view;
            do
            {
                // 1 -> Play
                // 2 -> Rules
                // 3 -> List players w/ score > x
                // 0 -> Exit
                input = view.MainMenu();

                //As escolhas do jogador em relação ao que quer fazer
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Play();
                        break;
                    case 2:
                        view.ShowPlayers(list);
                        break;
                    case 3:
                        ShowPlayersWithScore();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
            }
            while (input != 0);
        }

        private void Play()
        {
            // Pede ao viewer para nos dar um jogador
            Player p = view.AskForPlayer();

            // Põe esse jogador na lista
            list.Add(p);
        }

        private void ShowPlayersWithScore()
        {
            // Pede ao viewer por um score minimo
            int minScore = view.AskForMinimumScore();

            // Cria uma lista com o jogadores que tenha uma pontação acima de um certo valor
            IEnumerable<Player> players =
                GetPlayersWithScoreGreaterThan(minScore);

            // Mostrar jogadores
            view.ShowPlayers(players);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player p in list)
            {
                if (p.Score > minScore)
                    yield return p;
            }
        }
    }
}

