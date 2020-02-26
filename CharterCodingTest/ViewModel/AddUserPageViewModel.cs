#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

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