using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Architecture.Core.Entities
{
    public class Collaborater
    {
        public string Id { get; set; }
        public string FirstName {  get;  set; } = "Estebane";
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public Collaborater()
        {
        }

        public Collaborater( string firstName, string lastName, string email, string userName, string passwordHash=null, string id = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            PasswordHash = passwordHash;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
