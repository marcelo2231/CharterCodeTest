#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using CharterCodingTest.Models;
using CharterCodingTest.ViewModel.Base;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;

namespace CharterCodingTest.ViewModel
{
    /// <summary>
    ///     The user page view model.
    /// <para>
    public class UsersPageViewModel : ViewModelBase
    {
        #region Fields

        private RelayCommand _navigateToAddUserPageCommand;
        private readonly INavigationService _navigationService;
        private List<UserModel> _users;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the navigate to add user page Command.
        /// </summary>
        public RelayCommand NavigateToAddUserPageCommand
        {
            get
            {
                return _navigateToAddUserPageCommand
                    ?? (_navigateToAddUserPageCommand = new RelayCommand(() => _navigationService.NavigateTo(
                            ViewModelLocator.AddUserPage)));
            }
        }

        /// <summary>
        ///     Gets/sets the users.
        /// </summary>
        public List<UserModel> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
            }
        }

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     The default constructor.
        /// </summary>
        public UsersPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            // This should be called when creating the view model instead.
            // I will call from the constructor for simplicity.
            Initialize(); 
        }

        #endregion

        /// <summary>
        ///     Initializes view model.
        /// </summary>
        public void Initialize()
        {
            Users = new List<UserModel>()
            {
                new UserModel
                {
                    FirstName = "Marcelo",
                    LastName = "Almeida",
                    Age = "26",
                    Username = "marchiza"
                }
            };
        }

        #endregion
    }
}