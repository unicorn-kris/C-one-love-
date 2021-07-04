using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UsersAndAwards.DAL.Interface;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL
{
    public class AwardDao : IAwardDao
    {
        public string JsonFile = Path.Combine(Environment.CurrentDirectory, "Awards.json");

        private void RewriteFile(string json)
        {
            File.WriteAllText(JsonFile, json);
        }

        private List<Award> Deserialize()
        {
            if (File.Exists(JsonFile))
            {
                List<Award> users = JsonConvert.DeserializeObject<List<Award>>(JsonFile);
                return users;
            }
            else
                return null;
        }

        private string Serialize(object users)
        {
            var convertJSON = JsonConvert.SerializeObject(users);
            return convertJSON;
        }

        public void Add(Award user)
        {
            List<Award> users = Deserialize();
            users.Add(user);
            string json = Serialize(user);
            RewriteFile(json);
        }

        public void Delete(Guid id)
        {
            List<Award> awards = Deserialize();
            for (int i = 0; i < awards.Count; ++i)
                if (awards[i].Id == id)
                    awards.RemoveAt(i);
            string json = Serialize(awards);
            RewriteFile(json);
        }

        public IEnumerable<Award> GetAll()
        {
            List<Award> awards = Deserialize();
            return awards;
        }

        public void Update(Award award)
        {
            List<Award> awards = Deserialize();
            for (int i = 0; i < awards.Count; ++i)
                if (awards[i].Id == award.Id)
                    awards[i] = award;
            string json = Serialize(awards);
            RewriteFile(json);
        }
    }
}
