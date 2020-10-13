using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UserCreation.Model;
using UserCreation.View;

namespace UserCreation.Presenter
{
    public class UserCreationPresenter
    {
        private GUIManager view;
        private LogicManager model;

        public UserCreationPresenter(GUIManager view)
        {
            model = new LogicManager(this);
            this.view = view;
        }

        public void InsertNewUser(User u)
        {
            model.InsertNewUser(u);
        }

        public void NotifyNewUser(string name)
        {
            view.NewUserAdded(name);
        }


    }

}
