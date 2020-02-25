#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using CharterCodingTest.ViewModel.Base;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

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

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     The default constructor.
        /// </summary>
        public UsersPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        #endregion

        #endregion
    }
}