using System;

namespace classes_calc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Calc calc = new Calc();
            int num1 = 5, num2 = 8, per = 30;
            Console.WriteLine("Bye bye..");

            Console.WriteLine($"The result of {num1} + {num2} is {calc.Add(num1, num2)}");
            Console.WriteLine($"The result of {num1} - {num2} is {calc.Sub(num1, num2)}");
            Console.WriteLine($"The result of {num1} x {num2} is {calc.Mult(num1, num2)}");
            Console.WriteLine($"The result of {num1} / {num2} is {calc.Div(num1, num2)}");
            Console.WriteLine($"The result of {per}% of {num2} is {calc.Percent(num2, per)}");
            */

            
            CalcPro calc = new CalcPro();
            float num1 = 5, num2 = 8, num3 = 66;
            Console.WriteLine($"Result after sub {num1} is {calc.Sub(num1)}");
            Console.WriteLine($"Result after percent 20 is {calc.Percent(20)}");
            Console.WriteLine($"Result after add {num2} is {calc.Add(num2)}");
            Console.WriteLine($"Result after Reset is {calc.Reset()}");
            Console.WriteLine($"Result after add {num1} is {calc.Add(num1)}");
            Console.WriteLine($"Result after mult {num3} is {calc.Mult(num3)}");
            Console.WriteLine($"Result after div {num2} is {calc.Div(num2)}");
            
        }
    }


    class CalcPro
    {
        public float _result = 0;

        public float Percent(float x)
        {
            _result *= x/100;
            //_result = _result * x / 100;
            return _result;
        }

        public float Add(float x)
        {
            _result += x;
            return _result;
        }
        public float Sub(float x)
        {
            _result -= x;
            return _result;
        }
        public float Mult(float x)
        {
            _result *= x;
            return _result;
        }
        public float Div(float x)
        {
            _result /= x;
            return _result;
        }
        public float Reset()
        {
            _result = 0;
            return _result;
        }
    }

    class Calc
    {
        public float Add(float x, float y)
        {
            return x + y;
        }
        public float Sub(float x, float y)
        {
            return x - y;
        }
        public float Mult(float x, float y)
        {
            return x * y;
        }
        public float Div(float x, float y)
        {
            return x / y;
        }
        public float Percent(float val, float percent)
        {
            return val * percent / 100;
        }
    }
}
