using System;
using System.Collections.Generic;
using UserAndAwards.BLL.Interface;
using UsersAndAwards.DAL.Interface;
using UsersAndAwards.Entities;

namespace UserAndAwards.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao _userDao;

        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }
        public void Add(User user)
        {
            _userDao.Add(user);
        }

        public void Delete(Guid id)
        {
            _userDao.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public void Update(User user)
        {
            _userDao.Update(user);
        }
    }
}
