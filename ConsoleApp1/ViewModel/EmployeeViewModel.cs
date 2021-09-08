using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ConsoleApp1.Model;
namespace ConsoleApp1.ViewModel
{
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> ListEmployee { get; set; } =
   new ObservableCollection<Employee>();
        public  EmployeeViewModel()
        {
            this.ListEmployee.Add(
            new Employee
            {
                Id = 1,
                LastName = "Иванов",
                FirstName = "Петр",
                SecondName = "Иванович",
                Title = "Программист",
                Birthday = new DateTime(1981, 08, 10),
                Address = "Гагарина 3в",
                City = "Ростов-на-Дону",
                Region = "Ростовская область",
                Phone = 8988485674,
                Email = "dasha@bk.ru"
        });
            this.ListEmployee.Add(
                new Employee
                {
                Id = 2,
                LastName = "Петров",
                FirstName = "Петр",
                SecondName = "Петрович",   
                Title = "Экономист",
                Birthday = new DateTime(1981, 03, 20),
                Address = "Гагарина 1в",
                City = "Ростов-на-Дону",
                Region ="Ростовская область",
                Phone = 8988945874,
                Email = "yelenakolod@bk.ru"
            });

            this.ListEmployee.Add(
 new Employee
 {
                Id = 3,
                LastName = "Пилюлькин",
                FirstName = "Иван",
                SecondName = "Алексеевич",   
                Title = "Учитель",
                Birthday = new DateTime(2000, 03, 20),
                Address = "Комарова 1в",
                City = "Ростов-на-Дону",
                Region ="Ростовская область",
                Phone = 898894556978,
                Email = "yelena@bk.ru"
            });

        }
    }
}
    

