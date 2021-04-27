using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Computer : IComputer, IOverclock
    {
        private bool Overclock = false;
        private static Random random = new Random();
        public Enum procType { get ; set ; }
        public Enum MName { get ; set ; }
        public Enum OSType { get ; set ; }
        public int frequncy { get ; set ; }
        public int RAMCap { get ; set ; }
        public List<string> software { get ; set ; }
        public List<string> users { get ; set ; }

        public Computer(Enum procType, Enum MName, Enum OSType, int frequncy, int RAMCap, List<string> software, List<string> users)
        {
            this.procType = procType;
            this.MName = MName;
            this.OSType = OSType;
            this.frequncy = frequncy;
            this.RAMCap = RAMCap;
            this.software = software;
            this.users = users;
        }

        public Computer()
        {

        }

        public enum ProcList
        {
            AMDThreadripper = 1,
            ItelCorei9900ks,
            IntelCorei911700k,
            AMDFX,
            IntelCorei910900X,
            INTELCorei911900K,
            AMDAthlon3000G,
            INTELCeleronG5925
        }

        public enum MNameList
        {
            Intel = 1,
            AMD, 
            SnapDragon, 
            M, 
            Эльбпус, 
            A, 
            Kirin, 
            Exynos
        }

        public enum OSTypeList
        {
            Linux = 1,
            Windows,
            Ubuntu,
            Android,
            MACOs,
            WindowsMobile
        }

        static List<int> freqList = new List<int>() { 2800, 4200, 4000, 3200, 3400, 3000, 2900, 3250 };
        static List<int> RAMList = new List<int>() { 8, 16, 32, 12, 64, 128, 20, 36 };
        static List<List<string>> softwareList = new List<List<string>>
        {
            new List<string>{"ItellijIdea","VisualStudio","Steam"},
            new List<string>{"VSCode","Telegram","Spotify"},
            new List<string>{"Discord","CLion","Chrome"},
            new List<string>{"Microsoft Word","Web Stopm","Origin"}
        };
        static List<List<string>> usersList = new List<List<string>>
        {
            new List<string>{"Виктор","Администратор","Пользователь1"},
            new List<string>{"Иван","Студент 2","Преподователь"},
            new List<string>{"Евгения","Ольга","Яна"},
            new List<string>{"Николай","Алексей","Мама"}
        };

        public bool OverclockTheComputer(Enum procType)
        {
            switch (procType)
            {
                case ProcList.AMDThreadripper: Overclock = true;
                    break;
                case ProcList.AMDAthlon3000G: Overclock = false;
                    break;
                case ProcList.AMDFX: Overclock = true;
                    break;
                case ProcList.ItelCorei9900ks: Overclock = true;
                    break;
                case ProcList.INTELCorei911900K: Overclock = true;
                    break;
                case ProcList.IntelCorei911700k: Overclock = true;
                    break;
                case ProcList.INTELCeleronG5925: Overclock = false;
                    break;
                case ProcList.IntelCorei910900X: Overclock = false;
                    break;

            }
            return Overclock;
        }

        public static Computer Generate()
        {
            ProcList rndProc= (ProcList)Enum.GetValues(typeof(ProcList)).GetValue(random.Next(8));
            MNameList rndName = (MNameList)Enum.GetValues(typeof(MNameList)).GetValue(random.Next(8));
            OSTypeList rndOS = (OSTypeList)Enum.GetValues(typeof(OSTypeList)).GetValue(random.Next(6));
            return new Computer(
                rndProc,
                rndName,
                rndOS,
                RAMList[random.Next(RAMList.Count)],
                freqList[random.Next(freqList.Count)],
                softwareList[random.Next(softwareList.Count)],
                usersList[random.Next(usersList.Count)]
                );
        }

        public static List<Computer> Generate100()
        {
            List<Computer> computers = new List<Computer>();

            for (int i = 0; i < 100; i++)
            {
                ProcList rndProc = (ProcList)Enum.GetValues(typeof(ProcList)).GetValue(random.Next(8));
                MNameList rndName = (MNameList)Enum.GetValues(typeof(MNameList)).GetValue(random.Next(8));
                OSTypeList rndOS = (OSTypeList)Enum.GetValues(typeof(OSTypeList)).GetValue(random.Next(6));
                computers.Add(new Computer(
                    rndProc,
                    rndName,
                    rndOS,
                    freqList[random.Next(freqList.Count)],
                    RAMList[random.Next(RAMList.Count)],
                    softwareList[random.Next(softwareList.Count)],
                    usersList[random.Next(usersList.Count)]
                    ));
            }
            return computers;
        }

    }
}
