using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Calculations
    {
        public static double Addition(double firstNumber, double secondNumber)
        {
            double sum;

            sum = firstNumber + secondNumber;

            return sum;
        }

        public static double Subtraction(double firstNumber, double secondNumber)
        {
            double difference;

            difference = firstNumber - secondNumber;

            return difference;
        }

        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double product;

            product = firstNumber * secondNumber;

            return product;
        }

        public static double Division(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                return -1;

            double div;

            div = firstNumber / secondNumber;

            return div;
        }

        public static long Factorial(double selectedNumber)
        {

                if (selectedNumber < 0)
                    return -1;
                if (selectedNumber == 0)
                    return 1;
                else
                {
                    int selectedNumberInt = (int)selectedNumber;
                    long fact = 1;

                    while (selectedNumberInt != 0)
                    {
                        fact *= selectedNumberInt;
                        selectedNumberInt--;
                    }
                    return fact;
                }
         }

        public static double SquareRoot(double selectedRootNumber)
        {
            if (selectedRootNumber < 0)
                return -1;
           
            else
            {
                double squareRoot = Math.Sqrt(selectedRootNumber);

                return squareRoot;
            }
        }

        public static double PowerOperation(double firstNumber, double secondNumber)
        {
            long baseNumber = Convert.ToInt64(firstNumber);

            long powerNumber = Convert.ToInt64(secondNumber);

            if (baseNumber == 0 && powerNumber == 0) // Base and power must not be zero simultaneously.
                return -1;

            else if (powerNumber == 0) // All number's power of 0 is 1.
                return 1;

            else
            {

                if (powerNumber < 0) // If the power is a negative number, I code the power method.

                {

                    double negativePowerResult = Math.Pow(baseNumber, powerNumber);

                    return negativePowerResult;
                }

                else

                {
                    double powerResult = 1;

                    while (powerNumber > 0) // If the power is a positive number, I calculated the result by loop.
                    {

                        powerResult *= baseNumber;

                        powerNumber--;
                    }
                    return powerResult;
                }
            }
        }
    }
}

