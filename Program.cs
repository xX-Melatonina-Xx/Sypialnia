using System;

namespace Kalkulator
{
    class Program
    {
        static string ValidateNumOne(string numOneCheck)
        {
            bool check;
            string numOne = ""; //Bez "" krzyczy że numOne lub numTwo jest nieprzypisany (CS0165)
            do
            {   
                if (double.TryParse(numOneCheck, out double numOneValid))
                {
                    numOne = Convert.ToString(numOneValid);
                    check = true;
                }
                else
                {
                    Console.WriteLine("Błąd - proszę podać wartość liczbową:");
                    numOneCheck = Console.ReadLine();
                    check = false;                    
                }
                
            } while (check == false);
            
            return numOne;
        }

        static string ValidateNumTwo(string numTwoCheck)
        {
            bool check;
            string numTwo = "";
            do
            {
                if (double.TryParse(numTwoCheck, out double numTwoValid))
                {
                    numTwo = Convert.ToString(numTwoValid);
                    check = true;
                }
                else
                {
                    Console.WriteLine("Błąd - proszę podać wartość liczbową:");
                    numTwoCheck = Console.ReadLine();
                    check = false;
                }

            } while (check == false);

            return numTwo;
        }

        static void Main()
            {

            string userInput;

            Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");

            do
                {
                double numOne;
                double numTwo;
                bool check;

                    
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        //Moduł dodawania
                        case "+":
                            
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        numOne = Convert.ToDouble(ValidateNumOne(Console.ReadLine()));

                        Console.WriteLine("Podaj drugą liczbę:");
                        numTwo = Convert.ToDouble(ValidateNumTwo(Console.ReadLine()));
                       
                        Console.WriteLine($"Wynik: {numOne + numTwo}\n");
                        Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                        break;

                        //Moduł odejmowania
                        case "-":

                        Console.WriteLine("Podaj pierwszą liczbę:");
                        numOne = Convert.ToDouble(ValidateNumOne(Console.ReadLine()));

                        Console.WriteLine("Podaj drugą liczbę:");
                        numTwo = Convert.ToDouble(ValidateNumTwo(Console.ReadLine()));

                        Console.WriteLine($"Wynik: {numOne - numTwo}\n");
                        Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                        break;

                        //Moduł mnożenia
                        case "*":
                       
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        numOne = Convert.ToDouble(ValidateNumOne(Console.ReadLine()));

                        Console.WriteLine("Podaj drugą liczbę:");
                        numTwo = Convert.ToDouble(ValidateNumTwo(Console.ReadLine()));

                        Console.WriteLine($"Wynik: {numOne * numTwo}\n");
                        Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                        break;

                        //Moduł dzielenia
                        case "/":
                        
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        numOne = Convert.ToDouble(ValidateNumOne(Console.ReadLine()));

                        Console.WriteLine("Podaj drugą liczbę: ");
                        do
                            {                                
                                if (double.TryParse(Console.ReadLine(), out numTwo) && numTwo != 0)
                                {
                                    check = true;
                                }
                                else
                                {
                                    Console.WriteLine("Błąd - proszę podać wartość liczbową inną od zera");
                                    check = false;
                                }
                            } while (check == false);

                        Console.WriteLine($"Wynik: {numOne / numTwo}\n");
                        Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                        break;

                        //Moduł potęgowania
                        case "^":
                        
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        numOne = Convert.ToDouble(ValidateNumOne(Console.ReadLine()));

                        Console.WriteLine("Podaj drugą liczbę:");
                        numTwo = Convert.ToDouble(ValidateNumTwo(Console.ReadLine()));

                        Console.WriteLine($"Wynik: {Math.Pow(numOne, numTwo)}\n");
                        Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                        break;

                        //Moduł pierwiastkowania
                        case "sqrt":
                        
                        Console.WriteLine("Podaj liczbę do spierwiastkowania: ");
                        do
                            {
                                
                                if (double.TryParse(Console.ReadLine(), out numOne) && numOne >= 0)
                                {
                                    check = true;
                                }
                                else
                                {
                                    Console.WriteLine("Błąd: proszę podać nieujemną wartość liczbową");
                                    check = false;
                                }
                            } while (check == false);

                        
                        Console.WriteLine($"Wynik: {Math.Sqrt(numOne)}\n");
                        Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                        break;

                        case "end":
                            break;

                        default:
                            Console.WriteLine("Nieprawidłowa opcja\n");
                            break;
                    }

            } while (userInput != "end");
        }
    }
}