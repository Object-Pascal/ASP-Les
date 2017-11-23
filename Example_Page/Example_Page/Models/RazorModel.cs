using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_Page
{
    public class RazorModel
    {
        public User[] users { get; private set; }
        public RazorModel()
        {
            users = GetUsers();
        }

        private User[] GetUsers()
        {
            User[] userResult =
            {
                new User("Pascal", "Stoop", 19),
                new User("Levi", "Vlasblom", 19),
                new User("Kenley", "Strik", 18)
            };
            return userResult;
        }
        public void SetNewUsers()
        {
            users = new User[]
            {
                new User("Mohamed", "Hsaine", 12),
                new User("Stijn", "Verhelpen", 12),
                new User("Tim", "Reniers", 12)
            };
        }
    }
}