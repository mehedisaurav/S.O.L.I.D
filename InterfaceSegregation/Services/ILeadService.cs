using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Services
{

    /*  [Tanvir Arjel]
     public interface IEmployeeTasks
            {
               void CreateTask();
               void AssginTask();
               void WorkOnTask();
            }

    //
    public class Manager : IEmployeeTasks
        {
           public void CreateTask()
           {
               Console.WriteLine("Task created.");
           }

           public void AssginTask()
           {
               Console.WriteLine("Task assigned.");
           }

           // The Manager client has been forced to implement `WorkOnTask()` method although Manager does not work on task.
           public void WorkOnTask()
           {
               throw new NotImplementedException();
           }
        }
    */
    internal interface ILeadService
    {
        public void TaskCreate();
        public void TaskAssign();

    }

    public class LeadProgrammer : ILeadService, IProgrammerService
    {
        public LeadProgrammer(string position)
        {
            Console.WriteLine($".....{position.ToUpper()}....");
        }
        public void TaskAssign()
        {
            Console.WriteLine("Can task assigne!");
        }

        public void TaskCreate()
        {
            Console.WriteLine("Can task create!");
        }

        public void TaskDo()
        {
            Console.WriteLine("Can task do!");
        }
    }
}
