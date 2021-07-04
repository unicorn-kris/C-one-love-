﻿using System;
using System.Collections.Generic;

namespace UsersAndAwards.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public List<Award> Awards { get; set; }

    }
}
