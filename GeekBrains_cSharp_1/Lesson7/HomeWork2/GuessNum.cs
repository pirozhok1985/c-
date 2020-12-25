using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class GuessNum
    {
        public int Number { get; private set; }
        public int Tries { get; private set; }
        public string Result { get; private set; }

        public GuessNum()
        {
            Random rand = new Random();
            Number = rand.Next(1, 100);
            Tries = 5;
        }

        public void Compare(int num)
        {
            string advice = null;
            bool res = false;
            if (Number > num)
            {
                advice = "меньше";
            }
            else if (Number < num)
            {
                advice = "больше";
            }
            else 
            {
                res = true;
            }
            Tries--;
            if (res) Result = "Вы угадали!";
            else
            {
                if (Tries == 0) Result = "Вы не угадали!";
                else Result = string.Format("Вы не угадали!\nВаше число {1}\nУ вас осталось {0} попыток", Tries, advice);
            }
        }

        public void Reset()
        {
            Tries = 5;
        }
    }
}
