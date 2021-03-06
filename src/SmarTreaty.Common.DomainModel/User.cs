﻿using System;
using System.Collections.Generic;

namespace SmarTreaty.Common.DomainModel
{
    public class User : Entity<Guid>
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PrivateKey { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<SmartContract> SmartContracts { get; set; }
    }
}