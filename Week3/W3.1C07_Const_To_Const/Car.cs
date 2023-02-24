using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstCar
{
    internal class Car
    {   
        public int Mileage = 0;
        public void Drive() {
            Mileage += 1;
        }
    }
}