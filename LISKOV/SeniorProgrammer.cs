using LISKOV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV
{
    internal class SeniorProgrammer : ILead
    {
        public SeniorProgrammer(string position)
        {
            Console.WriteLine($"... { position.ToUpper() } ....");
        }
        public void TaskAssign()
        {
            Console.WriteLine("Can assign task!");
        }

        public void TaskCreate()
        {
            Console.WriteLine("Can create task!");
        }

        public void ToDoTask()
        {
            Console.WriteLine("Can work any task!");
        }
    }
}
