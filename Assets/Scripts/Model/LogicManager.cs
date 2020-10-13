using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UserCreation.Presenter;

namespace UserCreation.Model
{

    public class LogicManager
    {
        private UsersManager usersManager;
        private UserCreationPresenter presenter;

        public LogicManager(UserCreationPresenter presenter)
        {
            this.presenter = presenter;
            usersManager = new UsersManager();
        }

        public void InsertNewUser(User u)
        {
            usersManager.InsertNewUser(u);
            presenter.NotifyNewUser(u.GetName());
        }
    }

}