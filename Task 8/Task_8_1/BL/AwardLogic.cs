using System;
using System.Collections.Generic;
using UserAndAwards.BLL.Interface;
using UsersAndAwards.DAL.Interface;
using UsersAndAwards.Entities;

namespace UserAndAwards.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDao _awardDao;

        public AwardLogic(IAwardDao awardDao)
        {
            _awardDao = awardDao;
        }

        public void Add(Award award)
        {
            _awardDao.Add(award);
        }

        public void Delete(Guid id)
        {
            _awardDao.Delete(id);
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardDao.GetAll();
        }

        public void Update(Award award)
        {
            _awardDao.Update(award);
        }
    }
}
