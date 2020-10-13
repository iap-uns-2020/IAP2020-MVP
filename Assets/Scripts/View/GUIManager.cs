using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UserCreation.Model;
using UserCreation.Presenter;

namespace UserCreation.View
{
    public class GUIManager : MonoBehaviour
    {
        public InputField inputName, inputSurname, inputDNI;
        public Text labelNewUser;
        private UserCreationPresenter presenter;

        // Start is called before the first frame update
        void Start()
        {
            presenter = new UserCreationPresenter(this);
        }

        public void AddNewUser()
        {
            string name = inputName.text;
            string surname = inputSurname.text;
            string dni = inputDNI.text;
            User newUser = new User(name, surname, dni);
            presenter.InsertNewUser(newUser);
        }

        public void NewUserAdded(string name)
        {
            labelNewUser.text = "Se ha agregado el usuario " + name;
        }
    }
}
