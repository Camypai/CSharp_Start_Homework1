using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Game
    {
        public int Number { get; set; }
        public Stopwatch Stopwatch { get; set; }
        public int LastNumber { get; set; }

        public int NumbersHistoryCount { get; private set; }
//        private readonly List<int> NumbersHistory;

        public enum CheckSate
        {
            Greate = 1,
            Less = -1,
            Equal = 0
        }

        public Game()
        {
            Number = new Random().Next(1, 101);
            Stopwatch = Stopwatch.StartNew();
//            NumbersHistory = new List<int>();
        }

        public CheckSate CheckUserInput(int userNumber)
        {
            LastNumber = userNumber;
            NumbersHistoryCount++;
//            NumbersHistory.Add(LastNumber);

            if (userNumber > Number)
            {
                return CheckSate.Greate;
            }

            if (userNumber < Number)
            {
                return CheckSate.Less;
            }

            Stopwatch.Stop();
            return CheckSate.Equal;

//            Update?.Invoke();
        }
    }
}