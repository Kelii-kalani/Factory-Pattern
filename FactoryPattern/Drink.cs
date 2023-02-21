using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Drink : IMusubiTruck
    {
        public void FoodItem()
        {
            Console.WriteLine("Diamond Head sodas or Hawaiian Sun juice");
        }
    }
}
