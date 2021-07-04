using System;
using System.Collections.Generic;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL.Interface
{
    public interface IUserDao
    {
        
        void Add(User user);
        IEnumerable<User> GetAll();
        void Update(User user);
        void Delete(Guid id);
    }
}
