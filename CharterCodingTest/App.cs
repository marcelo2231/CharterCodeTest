#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using GalaSoft.MvvmLight.Views;
using CharterCodingTest.ViewModel.Base;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using CharterCodingTest.Activities;

namespace CharterCodingTest
{
    /// <summary>
    ///     The App class.
    /// </summary>
    public static class App
    {
        #region Fields

        private static ViewModelLocator locator;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the locator.
        /// </summary>
        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
                    DispatcherHelper.Initialize();

                    var nav = new NavigationService();

                    SimpleIoc.Default.Register<INavigationService>(() => nav);

                    nav.Configure(
                      ViewModelLocator.AddUserPage,
                      typeof(AddUserPageActivity));

                    nav.Configure(
                      ViewModelLocator.UsersPage,
                      typeof(UsersPageActivity));

                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }

        #endregion
    }
}