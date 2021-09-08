using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public  class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Title { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }

        public Employee() { }
        public Employee(int id, string lastName, string firstName,
        string secondName, string title, DateTime birthday, string address, string city, string region, long phone, string email)
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Title = title;
            this.Birthday = birthday;
            this.Address = address; 
            this.City = city;
            this.Region = region;
            this.Phone = phone;
            this.Email = email;
          
        }
    }
}

