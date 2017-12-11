using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_Page
{
    public class User
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }


        public User(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
    }
}