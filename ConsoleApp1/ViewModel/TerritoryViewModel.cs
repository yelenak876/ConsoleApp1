using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsoleApp1.ViewModel
{
    class TerritoryViewModel
    {
        public ObservableCollection<Territory> ListTerritory { get; set; } = new
  ObservableCollection<Territory>();
        public TerritoryViewModel()
        {
            this.ListTerritory.Add(new Territory
            {
                Id = 1,
                Discription = "Ростов-на-Дону"
            });
            this.ListTerritory.Add(new Territory
            {
                Id = 2,
                Discription = "Москва"
            });
            this.ListTerritory.Add(new Territory
            {
                Id = 3,
                Discription = "Сочи"
            });

        }
    }
    }
