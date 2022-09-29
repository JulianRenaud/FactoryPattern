using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IVehicle
    {
        public void Drive()
        {
            
        }
        public void Built()
        {
            Console.WriteLine();
            Console.WriteLine("Successfully Built!");
        }
    }
}
