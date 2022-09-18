// See https://aka.ms/new-console-template for more information
using InterfaceSegregation.Services;

Console.WriteLine("!!!!!! Interface Segregation !!!!!!!\n\n");


var juniorProgrammer = new Programmer("Junior Programmer");
juniorProgrammer.TaskDo();


var seniorProgrammer = new LeadProgrammer("Senior Programmer");
seniorProgrammer.TaskCreate();
seniorProgrammer.TaskAssign();
seniorProgrammer.TaskDo();

Console.Read();