using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class An18Wheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine();
            Console.Write("Building a new 18-wheeler .");
        }

    }
}
