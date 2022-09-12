
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV
{
    internal class HotCoffee : Services.IMakeHotCoffee
    {
        private string coffee;
        public void AddCoffee()
        {
            coffee = "Add coffee powder.\n";
        }

        public void AddSugar()
        {
            coffee += "After that added sugar.\n";
        }

        public void MixHotWater()
        {
            coffee += "Mix hot water.\n";
        }

        public void ServeCoffee()
        {
            AddCoffee();
            AddSugar();
            MixHotWater();
            Console.WriteLine(coffee);
        }
    }
}
