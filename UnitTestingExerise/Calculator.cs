using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExercise
{
    public class Calculator
    {
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
