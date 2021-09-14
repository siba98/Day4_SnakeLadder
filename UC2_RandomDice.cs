using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_SnakeLadder
{
    class UC2_RandomDice
    {
        public static void DiceRoll ()
        {
            int player1;
            Random rd = new Random();
            player1 = rd.Next(1, 7);
            Console.WriteLine("The player1 gets the random dice number is: " + player1);

        }
    }
}
