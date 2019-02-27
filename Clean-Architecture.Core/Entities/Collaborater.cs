using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Architecture.Core.Entities
{
    class Collaborater
    {
        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string UserName { get; private set; }
        public string PasswordHash { get; private set; }

        public Collaborater( string firstName, string lastName, string email, string userName, string passwordHash=null, string id = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            PasswordHash = passwordHash;
        }
    }
}
