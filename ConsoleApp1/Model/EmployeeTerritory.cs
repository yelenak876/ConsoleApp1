using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public class EmployeeTerritory
    {
        public int Id { get; set; }
        public string NameEmployeeTerritory { get; set; }
        public EmployeeTerritory() { }
        public EmployeeTerritory(int id, string nameEmployeeTerritory)
        {
            this.Id = id;
            this.NameEmployeeTerritory = nameEmployeeTerritory;

        }
    }
}