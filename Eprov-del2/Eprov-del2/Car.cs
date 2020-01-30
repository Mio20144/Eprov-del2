using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_del2
{
    class Car
    {
        
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();

        public bool Examine()
        {
            // om kontraband är mer än 1 så returneras true, annars false
            if (contrabandAmount > 0)
            {
                Console.WriteLine("Du hittade " + contrabandAmount + " kontraband");
                return true;
            }
            else
            {
                Console.WriteLine("Du hittade inga kontraband");
                return false;
            }
        }
        
    }
}
