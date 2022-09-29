using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.NewFolder
{
    internal class HeavyDuty : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine();
            Console.Write("Building a new heavy duty vehicle .");
        }
    }
}
