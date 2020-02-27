#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using CharterCodingTest.Models;
using System.Collections.Generic;

namespace CharterCodingTest.Singleton
{
    // I would usually create a database to store information like this.
    // In this case I would choose SQL Lite to store the users, but I believe
    // this would be out of the scope of this project so I am saving the users on
    // a singleton.
    public sealed class UsersListSingleton
    {
        #region Fields

        private static UsersListSingleton _instance = null;
        private List<UserModel> _user = new List<UserModel>();

        #endregion

        #region Properties

        ///<summary>
        ///    Gets and instance of <see cref="UsersListSingleton" />.
        ///</summary>
        public static UsersListSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersListSingleton();
                }

                return _instance;
            }
        }

        public List<UserModel> Users
        { 
            get => _user;
            set => _user = value;
        }

        #endregion

        #region Methods

        #region Constructor

        private UsersListSingleton()
        {
            Users.Add(new UserModel
            {
                Username = "marchiza",
                Password = "P@ssw0rd1",
                FirstName = "Marcelo",
                LastName = "Almeida",
                Age = "26",
                Id = 1
            });

            Users.Add(new UserModel
            {
                Username = "k.ktdidit",
                Password = "P@ssw0rd2",
                FirstName = "Kaitlin",
                LastName = "Almeida",
                Age = "24",
                Id = 2
            });

            Users.Add(new UserModel
            {
                Username = "js1974",
                Password = "P@ssw0rd3",
                FirstName = "John",
                LastName = "Smith",
                Age = "46",
                Id = 3
            });

            Users.Add(new UserModel
            {
                Username = "kiandurant",
                Password = "P@ssw0rd4",
                FirstName = "Kian",
                LastName = "Carlisle",
                Age = "16",
                Id = 4
            });
        }

        #endregion

        ///<summary>
        ///    Add User.
        ///</summary>
        public void AddUser(UserModel user)
        {
            Users.Add(user);
        }

        ///<summary>
        ///    remove User.
        ///</summary>
        public void RemoveUser(UserModel user)
        {
            Users.Remove(user);
        }

        #endregion
    }
}