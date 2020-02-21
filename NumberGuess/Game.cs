using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuess
{
    class Game
    {
        private Random _rand;
        private int _number;
        private int _range;

        public Game(Random rand, int range)
        {
            _rand = rand;
            _range = range;
        }
        public GuessResult Guess(int number)
        {
            if (number > _number) return GuessResult.IsLower;
            else if (number < _number) return GuessResult.IsGreater;
            else if (number == _number) return GuessResult.Succes;
            else return GuessResult.None;
        }
        public void Restart()
        {

        }
    }
}
