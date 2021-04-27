using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    interface IManufacture
    {
        string Name { get; set; }
        Enum Country { get; set; }
        int Employees { get; set; }

    }
}
