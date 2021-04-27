using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    interface IComputer
    {
        Enum procType { get;set; }
        Enum  MName{ get;set; }//manufacrurer Name
        Enum OSType { get;set; }
        int frequncy { get; set; }
        int RAMCap { get; set; }
        List<string> software { get; set; }
        List<string> users { get; set; }
    }
}
