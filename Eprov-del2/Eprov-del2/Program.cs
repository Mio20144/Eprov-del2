using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<Car> cars = new List<Car>();
            int carAmountInt = 0;
            bool success = false;
            while (success == false)
            {
                Console.WriteLine("Hur många bilar ska skapas?");
                string carAmount = Console.ReadLine();
                bool onlyContainsNumbers = carAmount.All(char.IsDigit);
                if (onlyContainsNumbers == true)
                {
                    if (carAmount.Length > 0)
                    {
                        carAmountInt = int.Parse(carAmount);
                        if (carAmountInt > 0)
                        {
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("Felaktig Input");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Felaktig Input");
                    }

                    
                    
                }
                else
                {
                    Console.WriteLine("Felaktig Input");
                }
                
            }

            for (int i = 0; i < carAmountInt; i++)
            {
                Car c = new Car();
                int type = generator.Next(0, 2);
                if (type == 0)
                {
                    c = new CleanCar();
                }
                else
                {
                    c = new ContrabandCar();
                }
                cars.Add(c);
            }
            bool success2 = false;
            int carChoice;
            int carsAmount = carAmountInt -= 1;
            while (success2 == false)
            {
                Console.WriteLine("Vilken bil vill du titta på? [0-" + carsAmount + "]");
                string examiner = Console.ReadLine();
                bool onlyContainsNumbers = examiner.All(char.IsDigit);
                if (onlyContainsNumbers == true)
                {
                    if (examiner.Length > 0)
                    {
                        carChoice = int.Parse(examiner);
                        if (carChoice < 0 || carChoice > carAmountInt)
                        {
                            Console.WriteLine("Felaktig Input");
                        }
                        else
                        {
                            Car c1 = cars[carChoice];
                            if (c1.alreadyChecked == true)
                            {
                                Console.WriteLine("Du har redan kollat den här bilen");
                            }
                            else
                            {
                                c1.Examine();
                                c1.alreadyChecked = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig Input");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Felaktig Input");
                }
            }
            

            Console.ReadLine();



        }
    }
}
