using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsoleApp1.ViewModel
{
    public class RegionViewModel
    {
        public ObservableCollection<Region> ListRegion { get; set; } = new
  ObservableCollection<Region>();
        public RegionViewModel()
        {
            this.ListRegion.Add(new Region
            {
                Id = 1,
                RegionDiscription  = "Ростовская область "
            });
            this.ListRegion.Add(new Region
            {
                Id = 2,
                RegionDiscription = "Московская область "
            });
            this.ListRegion.Add(new Region
            {
                Id = 3,
                RegionDiscription = "Республика Крым "
            });

        }
    }
}
