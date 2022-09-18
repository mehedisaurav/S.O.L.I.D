using LISKOV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV
{
    internal class JuniorProgrammer : IProgrammer
    {
        public JuniorProgrammer(string position)
        {
            Console.WriteLine($".... {position.ToUpper()} ....");
        }
        public void ToDoTask()
        {
            Console.WriteLine("Should work any task!");
        }
    }
}
