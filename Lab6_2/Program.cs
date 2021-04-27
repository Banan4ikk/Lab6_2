using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        enum countries
        {
            Russia = 1,
            USA,
            France,
            Italy,
            Belarus
        }
        
        static void Main(string[] args)
        {
            List<Computer> computers = Computer.Generate100();
            //task2
            //sort by Processor type
            List<Computer> procType = Computer.Generate100();

            List<Computer> procTypeNew = (from item in procType
                                          where item.procType.CompareTo(Computer.ProcList.AMDThreadripper) == 0
                                         select item).ToList();

            //With LINQ method
            List<Computer> procType2 = Computer.Generate100().Where(item => item.procType.CompareTo(Computer.ProcList.AMDAthlon3000G) == 0).ToList();//1


            //sort by Processor type and Processor Name
            List<Computer> procTypeAndName = Computer.Generate100();

            List<Computer> procTypeAndNameNew = (from item in procTypeAndName
                                                where item.procType.CompareTo(Computer.ProcList.AMDThreadripper) == 0 && item.MName.CompareTo(Computer.MNameList.AMD) == 0
                                                select item).ToList();

            //With LINQ
            List<Computer> procTypeAndName2 = Computer.Generate100().Where(item =>
            item.procType.CompareTo(Computer.ProcList.AMDThreadripper) == 0 && item.MName.CompareTo(Computer.MNameList.AMD) == 0).ToList();//2

            //sort by procName
            List<Computer> procTypeOreder = Computer.Generate100();

            List<Computer> procTypeOrederNew = (from item in procTypeOreder
                                                orderby item.procType 
                                                select item).ToList();


            List<Computer> procTypeOrederNew2 = procTypeOreder.OrderBy(item => item.procType).ToList();


            //sort by Accaunts and Hardware Capacity
            List<Computer> accsAndMemory = Computer.Generate100();

            var accsAndMemoryNew = (from item in accsAndMemory
                                   where item.users.SequenceEqual(new List<string> { "Иван", "Студент 2", "Преподователь" }) && item.RAMCap == 16
                                   select item).ToList();

            //With LINQ
            var accsAndMemory2 = Computer.Generate100().Where(item =>
            item.RAMCap == 128 && item.users.SequenceEqual(new List<string> { "Иван", "Студент 2", "Преподователь" })).ToList();



            //Selection from List to other Lists
            List<Computer> computers2 = Computer.Generate100();

            var model = (from i in computers2 select i.frequncy).ToList();
            List<int> models1 = computers2.Select(i => i.frequncy).ToList();//only freq

            var Capacity = (from i in computers2 select i.RAMCap).ToList();
            List<int> Capacity1 = computers2.Select(i => i.RAMCap).ToList();//only Hardaware Capacity

            var accs = (from i in computers2 select i.software).ToList();
            List<List<string>> accs1 = computers2.Select(i => i.software).ToList();



            List<Manufaturer> manufaturers = new List<Manufaturer>() {
            new Manufaturer("Intel", countries.USA, 15357868,2000),
            new Manufaturer("AMD", countries.Russia, 98432742,3500),
            new Manufaturer("SnapDragon", countries.Belarus, 129346654,4320),
            new Manufaturer("M", countries.France, 234748273, 3250),
            new Manufaturer("A", countries.USA, 43298622, 2130),
            new Manufaturer("Kirin", countries.Italy, 378543861,3000),
            new Manufaturer("Exynos", countries.Italy, 678427423,3051),
            new Manufaturer("Эльбпус", countries.Russia, 743266761,3400)
            };

            List<Computer> computers1 = Computer.Generate100();
            // join with LINQ
            var newManufacture = (from m in manufaturers
                                 join c in computers1 on m.ProductProcfrequncy equals c.frequncy
                                 select new { Name = c.MName, Model = m.Name, Employees = m.Employees, Frequncy = m.ProductProcfrequncy }).ToList();
            
            //join wudh LINQ methods
            var result = manufaturers.Join(computers1,
                                           m => m.ProductProcfrequncy,
                                           c => c.frequncy,
                                           (m, c) => new { Name = c.MName, Model = m.Name, Employees = m.Employees, Frequncy = m.ProductProcfrequncy }).ToList();

            string s = "каkue Tо Puccкие БykBы Bпеpemeshku c ЛаTincкиМи";

            string news = s.RemoveRussians();

            Computer computerr = new Computer();
            

            //Проверка на невозможность вызова метода больше 1 раза
            computerr.OverclockTheComputer(Computer.ProcList.AMDThreadripper);
            computerr.OverclockTheComputer(Computer.ProcList.INTELCeleronG5925);
        }
    }
}
