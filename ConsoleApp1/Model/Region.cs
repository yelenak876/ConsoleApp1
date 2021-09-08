using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public class Region
    {
 public int Id { get; set; }
        public string RegionDiscription { get; set; }
        public Region() { }
        public Region(int id, string regionDiscription)
        {
            this.Id = id;
            this.RegionDiscription = regionDiscription;
        }

    }
}
