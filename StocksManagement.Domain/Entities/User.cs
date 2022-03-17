﻿using StocksManagement.Application.RepositoryInterfaces.Generic;

namespace StocksManagement.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
