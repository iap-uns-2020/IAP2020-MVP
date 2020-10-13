using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserCreation.Model
{

    public class UsersManager
    {
        private List<User> users;

        public UsersManager()
        {
            users = new List<User>();
        }

        public void InsertNewUser(User u)
        {
            users.Add(u);
        }
    }
}