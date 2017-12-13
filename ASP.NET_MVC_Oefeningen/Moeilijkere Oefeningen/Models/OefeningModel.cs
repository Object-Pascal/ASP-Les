using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Moeilijkere_Oefeningen.Models
{
    public class OefeningModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public OefeningModel(string Username, string Password, string Email)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
        }
    }
}