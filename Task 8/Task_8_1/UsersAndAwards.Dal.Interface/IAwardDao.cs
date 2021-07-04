using System;
using System.Collections.Generic;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL.Interface
{
    public interface IAwardDao
    {
        
        void Add(Award award);
        IEnumerable<Award> GetAll();
        void Update(Award award);
        void Delete(Guid id);
    }
}
