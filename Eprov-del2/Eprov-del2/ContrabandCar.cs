using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eprov_del2
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passengers = generator.Next(1, 5);
            contrabandAmount = generator.Next(1, 5);
            alreadyChecked = false;
        }

    }
}
