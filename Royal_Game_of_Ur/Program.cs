using System;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class Program
    {
        private static void Main()
        {
            // List of player is our model
            List<Player> list = new List<Player>()
            { new Player("Player1", 100), new Player("Player2", 100) };

            // Create controllers
            Controller controller = new Controller(list);

            // Create view
            IView view = new GameUI(controller); //, list);

            // Start program
            controller.Run(view);
        }
    }
}
