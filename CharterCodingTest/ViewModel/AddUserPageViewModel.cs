#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using CharterCodingTest.Models;
using CharterCodingTest.Singleton;
using CharterCodingTest.Validation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace CharterCodingTest.ViewModel
{
    /// <summary>
    ///     The add user page view model.
    /// </summary>
    public class AddUserPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly INavigationService _navigationService;
        private RelayCommand _addUserCommand;
        private RelayCommand _cancelCommand;
        private UserModel _user = new UserModel();
        private readonly UsersListSingleton _userListSingleton = UsersListSingleton.Instance;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the add user Command.
        /// </summary>
        public RelayCommand AddUserCommand
        {
            get
            {
                return _addUserCommand
                    ?? (_addUserCommand = new RelayCommand(addUser));
            }
        }

        /// <summary>
        ///     Gets the cancel Command.
        /// </summary>
        public RelayCommand CancelCommand
        {
            get
            {
                return _cancelCommand
                    ?? (_cancelCommand = new RelayCommand(cancel));
            }
        }

        /// <summary>
        ///     Gets/sets the user.
        /// </summary>
        public UserModel User
        {
            get => _user;
            set => _user = value;
        }

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     The default constructor.
        /// </summary>
        public AddUserPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        #endregion

        /// <summary>
        ///     Adds an user to list.
        /// </summary>
        private void addUser()
        {
            var validationHelper = new UserValidation();

            if (validationHelper.ValidatePasswordNullOrWhiteSpace(_user.Password) &&
                validationHelper.ValidatePassword(_user.Password) &&
                validationHelper.ValidatePasswordLength(_user.Password) &&
                validationHelper.ValidatePasswordSequence(_user.Password) &&
                validationHelper.ValidateUsername(_user.Username) &&
                validationHelper.ValidateFirstName(_user.FirstName) &&
                validationHelper.ValidateLastName(_user.LastName) &&
                validationHelper.ValidateAge(_user.Age))
            {
                _userListSingleton.AddUser(new UserModel
                {
                    Username = _user.Username,
                    Password = _user.Password,
                    FirstName = _user.FirstName,
                    LastName = _user.LastName,
                    Age = _user.Age,
                });

                _navigationService.GoBack();
            }
            else
            {
                // TODO: Pop up error message
            }
        }

        /// <summary>
        ///     Cancels adding a user.
        /// </summary>
        private void cancel()
        {
            _navigationService.GoBack();
        }

        #endregion
    }
}