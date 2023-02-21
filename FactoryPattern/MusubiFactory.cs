using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class MusubiFactory
    {
        public IMusubiTruck GetFood(string menueItem)
        {
            switch (menueItem.ToLower())
            {
                case "musubi":
                    return new Musubi();
                case "drink":
                    return new Drink();
                default:
                    return new Musubi();
            }
        }
    }
}
