using System;
using System.Collections.Generic;
using UsersAndAwards.Entities;

namespace UserAndAwards.BLL.Interface
{
    public interface IUserLogic
    {
        void Add(User user);
        IEnumerable<User> GetAll();
        void Update(User user);
        void Delete(Guid id);

    }
}
