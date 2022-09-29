using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.NewFolder
{
    internal class MotorTricycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine();
            Console.Write("Building a new motor tricycle .");
        }
    }
}
