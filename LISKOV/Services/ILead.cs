using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV.Services
{
    internal interface ILead : IProgrammer
    {
        public void TaskCreate();
        public void TaskAssign();
    }
}
