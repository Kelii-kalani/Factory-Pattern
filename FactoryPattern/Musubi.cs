using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Musubi : IMusubiTruck
    {
        public void FoodItem()
        {
            Console.WriteLine("One ono Spam Musubi");
        }
    }
}
