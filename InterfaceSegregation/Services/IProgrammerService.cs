using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Services
{
    internal interface IProgrammerService
    {
        public void TaskDo();
    }

    public class Programmer : IProgrammerService
    {
        public Programmer(string position)
        {
            Console.WriteLine($"....{position.ToUpper()}....");
        }
        public void TaskDo()
        {
            Console.WriteLine("Programmer should complete the task!");
        }
    }
}
