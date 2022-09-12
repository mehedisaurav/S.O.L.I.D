using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV.Services
{
    internal interface IMakeHotCoffee : IMakingHotCoffee
    {
        public void AddCoffee();
        public void AddSugar();

        public void ServeCoffee();
    }
}
