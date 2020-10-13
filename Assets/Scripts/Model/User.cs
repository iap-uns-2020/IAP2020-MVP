using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserCreation.Model
{
    public class User
    {
        private string name;
        private string surname;
        private string dni;

        public User(string name, string surname, string dni)
        {
            this.name = name;
            this.surname = surname;
            this.dni = dni;
        }

        public string GetName()
        {
            return name;
        }
    }

}