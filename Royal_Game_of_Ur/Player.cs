using System;
using System.Collections.Generic;

namespace Royal_Game_of_Ur
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name} ({Score})";
        }
    }
}
