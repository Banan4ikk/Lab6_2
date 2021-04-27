using System;
using System.Collections.Generic;

namespace Lab6_2
{
    public class Manufaturer : IManufacture
    {
        public string Name { get ; set ; }
        public Enum Country { get ; set ; }
        public int Employees { get ; set ; }
        public int ProductProcfrequncy { get; set; }


        public Manufaturer()
        {

        }

        public Manufaturer(string Name, Enum Country, int Employees, int ProductProcfrequncy)
        {
            this.Name = Name;
            this.Country = Country;
            this.Employees = Employees;
            this.ProductProcfrequncy = ProductProcfrequncy;
        }
    }
}