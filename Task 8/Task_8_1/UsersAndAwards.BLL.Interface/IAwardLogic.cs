using System;
using System.Collections.Generic;
using UsersAndAwards.Entities;

namespace UserAndAwards.BLL.Interface
{
    public interface IAwardLogic
    {
        void Add(Award award);
        IEnumerable<Award> GetAll();
        void Update(Award award);
        void Delete(Guid id);
    }
}
