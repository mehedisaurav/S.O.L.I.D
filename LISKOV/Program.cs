// See https://aka.ms/new-console-template for more information
using LISKOV;

Console.WriteLine("Hello, World!");

Console.WriteLine("S.O.L.I.D = > LISKOV");

Console.WriteLine("-------------------------------------------");

JuniorProgrammer junior  = new JuniorProgrammer("Junior Programmer");
junior.ToDoTask();

SeniorProgrammer senior = new SeniorProgrammer("Senior Programmer");
senior.TaskCreate();
senior.TaskAssign();
senior.ToDoTask();