using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using UsersAndAwards.DAL.Interface;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL
{
    public class UserDao : IUserDao
    {
        public string JsonFile = Path.Combine(Environment.CurrentDirectory, "Users.json");

        private void RewriteFile(string json)
        {
            File.WriteAllText(JsonFile, json);
        }

        private List<User> Deserialize()
        {
            if (File.Exists(JsonFile))
            {
                List<User> users = JsonConvert.DeserializeObject<List<User>>(JsonFile);
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

        public void Add(User user)
        {
            List<User> users = Deserialize();
            users.Add(user);
            string json = Serialize(user);
            RewriteFile(json);
        }

        public void Delete(Guid id)
        {
            List<User> users = Deserialize();
            for (int i = 0; i < users.Count; ++i)
                if (users[i].Id == id)
                    users.RemoveAt(i);
            string json = Serialize(users);
            RewriteFile(json);
        }

        public IEnumerable<User> GetAll()
        {
            List<User> users = Deserialize();
            return users;
        }

        public void Update(User user)
        {
            List<User> users = Deserialize();
            for (int i = 0; i < users.Count; ++i)
                if (users[i].Id == user.Id)
                    users[i] = user;
            string json = Serialize(users);
            RewriteFile(json);
        }
    }
}
