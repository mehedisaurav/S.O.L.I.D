using LISKOV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV
{
    public class ColdCoffee : IMixColdOrIceForCoffee
    {
        public string MixColdOrIce()
        {
            return "Added Ice.";
        }
    }
}
