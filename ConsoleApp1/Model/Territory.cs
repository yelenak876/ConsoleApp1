using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Territory
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public Territory() { }
        public Territory(int id, string discription)
        {
            this.Id = id;
            this.Discription = discription;
        }

    }
}
