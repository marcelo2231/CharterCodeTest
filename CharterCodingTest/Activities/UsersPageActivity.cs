#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using Android.App;
using Android.OS;
using Android.Widget;
using CharterCodingTest.Adapters;
using CharterCodingTest.Models;
using CharterCodingTest.ViewModel;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;

namespace CharterCodingTest.Activities
{
    ///<summary>
    ///    The Users page activity also the main activity.
    ///</summary>
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    class UsersPageActivity : ActivityBase
    {
        #region Fields

        private Button _addUserButton;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the view model.
        /// </summary>
        private UsersPageViewModel ViewModel
        {
            get
            {
                return App.Locator.UsersPageViewModel;
            }
        }

        ///<summary>
        ///    The add user button.
        ///</summary>
        public Button AddUserButton
        {
            get
            {
                return _addUserButton
                    ?? (_addUserButton = FindViewById<Button>(Resource.Id.AddUserButton));
            }
        }

        ///<summary>
        ///    The User list view.
        ///</summary>
        public Button UsersListView
        {
            get
            {
                return _addUserButton
                    ?? (_addUserButton = FindViewById<ListView>(Resource.Id.UsersListView));
            }
        }

        #endregion

        #region Methods

        ///<summary>
        ///    Overrides the on create method.
        ///</summary>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UsersPage);

            // Binding
            AddUserButton.SetCommand("Click", ViewModel.NavigateToAddUserPageCommand);

            var users = new List<UserModel>()
            {
                new UserModel
                {
                    FirstName = "Marcelo",
                    LastName = "Almeida",
                    Age = "26",
                    Username = "marchiza"
                }
            };
            var adapter = new UserCustomAdapter(this, users);
        }

        #endregion
    }
}