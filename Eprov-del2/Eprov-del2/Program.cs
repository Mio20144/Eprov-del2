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
            //generator som används för att avgöra om car är clean eller contraband
            Random generator = new Random();
            //lista där bilar läggs in
            List<Car> cars = new List<Car>();
            int carAmountInt = 0;
            bool success = false;
            //loopen avslutar när man väljer ett värde på över 0 som inte innehåller siffror
            while (success == false)
            {
                Console.WriteLine("Hur många bilar ska skapas?");
                string carAmount = Console.ReadLine();
                //kollar om carAmount bara innehåller siffror
                bool onlyContainsNumbers = carAmount.All(char.IsDigit);
                if (onlyContainsNumbers == true)
                {
                    //kollar om längden är längre än noll
                    if (carAmount.Length > 0)
                    {
                        //omvandlar stringen till en int
                        carAmountInt = int.Parse(carAmount);
                        //kollar om man skapar mer än 0 bilar
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
            //loop som körs så många gånger som antal bilar man valt. 
            for (int i = 0; i < carAmountInt; i++)
            {
                //instantierar en ny car varje loop
                Car c = new Car();
                int type = generator.Next(0, 2);
                //det är 50-50 om bilen innehåller kontraband eller inte
                if (type == 0)
                {
                    c = new CleanCar();
                }
                else
                {
                    c = new ContrabandCar();
                }
                //lägger till bilen i listan
                cars.Add(c);
            }
            bool success2 = false;
            int carChoice;
            //int som är 1 mindre än antalet bilar så att listan fungerar när man skriver 0
            int carsAmount = carAmountInt -= 1;
            while (success2 == false)
            {
                Console.WriteLine("Vilken bil vill du titta på? [0-" + carsAmount + "]");
                string examiner = Console.ReadLine();
                //samma typkonvertering och säkerhet som tidigare
                bool onlyContainsNumbers = examiner.All(char.IsDigit);
                if (onlyContainsNumbers == true)
                {
                    if (examiner.Length > 0)
                    {
                        carChoice = int.Parse(examiner);
                        //valet av bil får inte vara mindre eller mer än antalet bilar i listan. Dessa parametrar gör att spelet inte kraschar
                        if (carChoice < 0 || carChoice > carAmountInt)
                        {
                            Console.WriteLine("Felaktig Input");
                        }
                        else
                        {
                            //skapar en ny bil med samma värden som bilen i listan på den platsen
                            Car c1 = cars[carChoice];
                            //kollar om man redan undersökt bilen
                            if (c1.alreadyChecked == true)
                            {
                                Console.WriteLine("Du har redan kollat den här bilen");
                            }
                            else
                            {
                                //metod som undersöker om det finns kontraband eller inte i bilen
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
