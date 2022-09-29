using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Vehicles
{
    internal class ReallyHeavyDuty : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine();
            Console.Write("Building a new really heavy duty vehicle .");
        }
    }
}
