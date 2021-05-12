using System;
using System.Collections.Generic;
using System.Text;

namespace Royal_Dame_of_Ur
{
    public enum PlayerType
    {
        Player1,
        Player2,
        Neutral
    }

    /// Guarda o estado de cada turno
    /// 
    /// ROLLING o jogador tem de "rodar" o dado e recebe o resultado em moves(0, 1, 2, etc. moves).
    /// 
    /// SELECTING o jogador deve selecionar a peça que quer mover.
    ///
    /// MOVING é o movimento da peça selecionada e espera que o movimento termine.
    /// 
    /// Aseguir a estes três passos,
    /// O jogo termina o turno e repete.

    public enum TurnStates
    {
        ROLLING,
        SELECTING,
        MOVING
    }

    public class Controller
     {
        const int NUM_TILES = 20;
        const int CENTER_TILES = 8;
        const float MOVE_WAIT_TIME = 1.5f;

        private int player1Points = 0;
        private int player2Points = 0;

        private PlayerType currentTurn = PlayerType.Player1;
        private TurnStates currentTurnState = TurnStates.ROLLING;

        // Numero de movimentos num turno
        int roll = 0;
        // Flag para ver se o player etsá na casa com a rosa
        bool landedOnRosette = false;
    }
}
