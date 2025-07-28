using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;

            do
            {
                double numOne;
                double numTwo;
                bool check;
                
                Console.WriteLine("Wybierz operację (+ , - , * , / , ^ , sqrt) lub zakończ (end)");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    //Moduł dodawania
                    case "+":
                        do
                        {
                            Console.WriteLine("Podaj pierwszą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numOne))
                                {
                                    check = true;
                                }
                            else
                                {
                                    Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                    check = false;
                                }
                        } while (check == false);

                        do
                        {
                             Console.WriteLine("Podaj drugą liczbę: ");
                             if (double.TryParse(Console.ReadLine(), out numTwo))
                                {
                                    check = true;
                                }
                             else
                                {
                                    Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                    check = false;
                                }
                        } while (check == false);


                        double resultAdd = numOne + numTwo;
                        Console.WriteLine($"Wynik: {resultAdd}\n");
                        break;
                    
                    //Moduł odejmowania
                    case "-":
                        do
                        {
                            Console.WriteLine("Podaj pierwszą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numOne))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);

                        do
                        {
                            Console.WriteLine("Podaj drugą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numTwo))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);


                        double resultSubt = numOne - numTwo;
                        Console.WriteLine($"Wynik: {resultSubt}\n");
                        break;

                    //Moduł mnożenia
                    case "*":
                        do
                        {
                            Console.WriteLine("Podaj pierwszą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numOne))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);

                        do
                        {
                            Console.WriteLine("Podaj drugą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numTwo))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);

                        double resultMult = numOne * numTwo;
                        Console.WriteLine($"Wynik: {resultMult}\n");
                        break;

                    //Moduł dzielenia
                    case "/":
                        do
                        {
                            Console.WriteLine("Podaj pierwszą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numOne))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);

                        do
                        {
                            Console.WriteLine("Podaj drugą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numTwo) && numTwo != 0)
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową inną od zera");
                                check = false;
                            }
                        } while (check == false);

                        double resultDiv = numOne / numTwo;
                        Console.WriteLine($"Wynik: {resultDiv}\n");
                        break;

                    //Moduł potęgowania
                    case "^":
                        do
                        {
                            Console.WriteLine("Podaj pierwszą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numOne))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);

                        do
                        {
                            Console.WriteLine("Podaj drugą liczbę: ");
                            if (double.TryParse(Console.ReadLine(), out numTwo))
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: proszę podać wartość liczbową");
                                check = false;
                            }
                        } while (check == false);

                        double resultExp = Math.Pow(numOne, numTwo);
                        Console.WriteLine($"Wynik: {resultExp}\n");
                        break;
                    
                    //Moduł pierwiastkowania
                    case "sqrt":
                        do
                        {
                            Console.WriteLine("Podaj liczbę do spierwiastkowania: ");
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

                        double resultSqrt = Math.Sqrt(numOne);
                        Console.WriteLine($"Wynik: {resultSqrt}\n");
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
