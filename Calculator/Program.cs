using System;
using System.Globalization; // to be able to use the dot for decimal numbers.
using System.Text; // to be able to use the root symbol.
using Business.Concrete;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // to be able to use the root symbol

            object defaultReady = 'Q'; // Boxing the object

            string? userInputReady = null;

            char ready = '\0';


            string? userInputFirstNumber = null;

            string? userInputSecondNumber = null;

            double firstNumber = 0;

            double secondNumber = 0;


            string? userInputSelect = null;

            double selection = 0;


            (bool readyCheck, bool firstNumberCheck, bool secondNumberCheck, bool selectionCheck, bool selectedCalculationCheck) Checkings; // Declaring a tuple variable

            Checkings = (false, false, false, false, false);


            bool firstNumberAgain = false;

            bool secondNumberAgain = false;


            var selectedCalculation = 0;

            byte runAgain = 0;


            // todo code the methods in the Business project.


            Console.WriteLine("\n\n\n\n\t\t\t\t\t*** CALCULATOR ***\n\n");

            Console.WriteLine("In the application, you need to enter 2 numerical values for your calculation." +
                "\n\nAfter that, you will choose a calculation which you want to perform." +
                "\n\nFinally, you will be able to see the result.");

            Console.WriteLine("\n\n\nIf you are ready, let's get started! Press 'r' to continue. Press 'q' to quit."); // checking that is the user ready or not

            ready = (char)defaultReady; // Unboxing the object

            userInputReady = Console.ReadLine();

            Checkings.readyCheck = char.TryParse(userInputReady, out ready);

            do
            {

                if (ready != 'q' && ready != 'Q' && ready != 'r' && ready != 'R')
                {
                    Console.WriteLine("\nYou have entered an invalid value. Press 'r' to continue or 'q' to quit." +
                        "\n\n\t--- The app is closing. ---");
                    Console.ReadKey();
                    return;
                }

                if (ready == 'q' || ready == 'Q')
                {

                    Console.WriteLine("\n\t--- The app is closing. ---");
                    Console.ReadKey();
                    return;
                }

                else if (ready == 'r' || ready == 'R')

                {
                    do
                    {
                        firstNumberAgain = false;

                        Console.WriteLine("\n\nEnter the first value: ");

                        userInputFirstNumber = Console.ReadLine(); // Input of the first value.


                        // To check the first input and dot for the decimal value instead of comma.
                        Checkings.firstNumberCheck = double.TryParse(userInputFirstNumber, NumberStyles.Any, CultureInfo.InvariantCulture, out firstNumber);

                        if (!Checkings.firstNumberCheck)

                        {
                            // An error message for the invalid first number

                            Console.WriteLine("\nYou have entered an invalid value. You must enter a numerical value. Please enter the numbers again.");

                            firstNumberAgain = true; // getting a new number for first value until it is valid.
                        }


                    } while (firstNumberAgain == true);

                    do

                    {

                        secondNumberAgain = false;

                        Console.WriteLine("\nEnter the second value: "); // Input of the second value

                        userInputSecondNumber = Console.ReadLine();


                        // To check the second input and dot for the decimal value instead of comma
                        Checkings.secondNumberCheck = double.TryParse(userInputSecondNumber, NumberStyles.Any, CultureInfo.InvariantCulture, out secondNumber);

                        if (!Checkings.secondNumberCheck)

                        {
                            // An error message for the invalid second value.

                            Console.WriteLine("\nYou have entered an invalid value. You must enter a numerical value. Please enter the numbers again."); //Hatalı Değer Mesajı

                            secondNumberAgain = true; // getting a new number for second value until it is valid.

                        }

                    } while (secondNumberAgain == true);

                }


                Console.WriteLine("\nYou have entered the numbers. You will choose that which calculations you want to do in the below.\n");

                // Available Calculations in the Calculator

                Console.WriteLine("1-) Addition\n\n2-) Subtraction\n\n3-) Multiplication\n\n4-) Division\n\n" +

                  "5-) Factorial\n\n" +

                  "6-) Square Root \n\n7-) Power Operation");



                Console.WriteLine("\n\nChoose one of the calculations: "); // Selected Calculation by user.


                selectedCalculation = Convert.ToInt32(Console.ReadLine());



                switch (selectedCalculation)

                {

                    case 1:  // Addition

                        double sum = Calculations.Addition(firstNumber, secondNumber);

                        Console.WriteLine("\nYou have chosen the addition. The result is: " + sum);

                        break;


                    case 2: // Subtraction

                        double difference = Calculations.Subtraction(firstNumber, secondNumber);

                        Console.WriteLine("\nYou have chosen the subtraction. The result is: " + difference);

                        break;


                    case 3: // Multiplication

                        double product = Calculations.Multiplication(firstNumber, secondNumber);

                        Console.WriteLine("\nYou have chosen the multiplication. The result is: " + product);

                        break;


                    case 4: // Division

                        double div = Calculations.Division(firstNumber, secondNumber);

                        if (div == -1) // A denominator cannot be zero.

                        {
                            Console.WriteLine("\n\n !!! No numbers can divide by 0. Enter a valid number. " +

                              "\n\n\t---The app is running again.---");

                            runAgain = 1;
                        }

                        else

                        {
                            runAgain = 0;
                            Console.WriteLine("\nYou have chosen the division. The result is: " + div);
                        }

                        break;


                    case 5: // Factorial

                        Console.WriteLine("\nWhich number do you want to calculate its factorial? You need to enter your first number or second number:");
                        userInputSelect = Console.ReadLine();

                        Checkings.selectionCheck = double.TryParse(userInputSelect, NumberStyles.Any, CultureInfo.InvariantCulture, out selection);


                        if (!Checkings.selectionCheck)
                        {
                            Console.WriteLine("\nYou have chosen an invalid number. You need to enter a numerical value. Enter the numbers again." +
                                "\n\n\t---The app is running again--- ");
                            runAgain = 1;
                        }

                        int selectionInt = (int)selection;
                        int firstNumberInt = (int)firstNumber;
                        int secondNumberInt = (int)secondNumber;

                        if (selectionInt != firstNumberInt && selectionInt != secondNumberInt)
                        {
                            Console.WriteLine("\nYou have selected an another value. You need to select one of your original values. Enter the numbers again." +
                               "\n\n\t---The app is running again--- ");
                            runAgain = 1;
                        }

                        else
                        {
                            if (selectionInt == firstNumberInt)
                            {
                                long fact = Calculations.Factorial(selectionInt);
                                Console.WriteLine("\nYou have chosen the factorial. The result is: " + fact);
                            }

                            else if (selectionInt == secondNumberInt)
                            {
                                long fact = Calculations.Factorial(selectionInt);
                                Console.WriteLine("\nYou have chosen the factorial. The result is: " + fact);
                            }
                        }
                        break;


                    case 6: // Square Root

                        Console.WriteLine("\nWhich number do you want to calculate its square root? You need to enter your first number or second number:");
                        userInputSelect = Console.ReadLine();

                        Checkings.selectionCheck = double.TryParse(userInputSelect, NumberStyles.Any, CultureInfo.InvariantCulture, out selection);


                        if (!Checkings.selectionCheck)
                        {
                            Console.WriteLine("\nYou have chosen an invalid number. You need to enter a numerical value. Enter the numbers again." +
                                "\n\n\t---The app is running again--- ");
                            runAgain = 1;
                        }

                        selectionInt = (int)selection;
                        firstNumberInt = (int)firstNumber;
                        secondNumberInt = (int)secondNumber;

                        if (selectionInt != firstNumberInt && selectionInt != secondNumberInt)
                        {
                            Console.WriteLine("\nYou have selected an another value. You need to select one of your original values. Enter the numbers again." +
                               "\n\n\t---The app is running again--- ");
                            runAgain = 1;
                        }

                        else
                        {
                            if (selectionInt == firstNumberInt)
                            {
                                double squareRoot = Calculations.SquareRoot(selectionInt);
                                Console.WriteLine("\nYou have chosen square root operation. The result is: " + squareRoot);
                            }

                            else if (selectionInt == secondNumberInt)
                            {
                                double squareRoot = Calculations.SquareRoot(selectionInt);
                                Console.WriteLine("\nYou have chosen square root operation. The result is: " + squareRoot);
                            }
                        }
                        break;


                    case 7: // Power Operation

                        double powerResult = Calculations.PowerOperation(firstNumber, secondNumber);

                        if (powerResult == -1)
                        {
                            Console.WriteLine("\nBase and power must not be zero simultaneously.Enter the numbers again." +
                                "\n\n\t---The app is running again.---");

                            runAgain = 1;
                        }
                        else if (powerResult == 1)
                        {
                            Console.WriteLine("\nYou have chosen the power operation. The result is 1");
                            runAgain = 0;
                        }
                        else
                        {
                            Console.WriteLine("\nYou have chosen the power operation. The result is " + powerResult);
                            runAgain = 0;
                        }
                        break;

                    default: // An error message for selecting an unavailable calculation.

                        runAgain = 1; // to run the app again.

                        Console.WriteLine("\nYou have chosen an invalid calculation. Select one of the calculations in the above." +

                          "\n\n\t---The app is running again.---");

                        break;
                }



                if (runAgain == 0) // asking to user for running the app again.

                {

                    Console.WriteLine("\n\nIf you want to use the app again, enter 1");

                    runAgain = byte.Parse(Console.ReadLine());

                }

            } while (runAgain == 1); // The condition for running the app again.
            Console.ReadKey();

            //todo design UI for the project. 
        }
    }
}