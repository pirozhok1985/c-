using System;

namespace HomeWork3
{
    class Rational
    {
        private int a, b;
        public int A 
        {
            get
            {
                return a;
            }
            private set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            private set
            {
                b = value;
            }
        }

        public Rational(string s)
        {
            if (int.TryParse(s.Split('/')[0], out a) && int.TryParse(s.Split('/')[1], out b))
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Знаменатель должен быть отличен от нуля");
                }
            }
            else 
            {
                throw new ApplicationException("Числитель и знаменатель дроби должны быть целыми числами");
            }
        }

        public Rational(int a, int b)
        {
            this.a = a;
            this.b = b;
            if (b == 0)
            {
                throw new DivideByZeroException("Знаменатель должен быть отличен от нуля");
            }
        }

        public override string ToString()
        {
            return string.Format($"{A}/{B}");
        }

        public static string sum(Rational obj1, Rational obj2)
        {
            return string.Format($"{obj1.A * obj2.B + obj2.A * obj1.B}/{obj1.B * obj2.B}");
        }

        public static string sub(Rational obj1, Rational obj2)
        {
            return string.Format($"{obj1.A * obj2.B - obj2.A * obj1.B}/{obj1.B * obj2.B}");
        }

        public static string multi(Rational obj1, Rational obj2)
        {
            return string.Format($"{obj1.A * obj2.A}/{obj1.B * obj2.B}");
        }

        public static string div(Rational obj1, Rational obj2)
        {
            return string.Format($"{obj1.A * obj2.B}/{obj1.B * obj2.A}");
        }
    }
}
