﻿using System;
using Core.Persistence.Repositories;

namespace nDomain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }

        public Brand()
        {
            
        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}

