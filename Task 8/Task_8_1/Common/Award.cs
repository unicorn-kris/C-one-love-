using System;
using System.Collections.Generic;

namespace UsersAndAwards.Entities
{
    public class Award
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<User> Users { get; set; }
    }
}