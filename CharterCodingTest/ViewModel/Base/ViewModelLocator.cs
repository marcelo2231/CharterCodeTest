#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace CharterCodingTest.ViewModel.Base
{
    /// <summary>
    ///     The view model locator class
    /// </summary>
    public class ViewModelLocator
    {
        #region Fields

        public const string UsersPage = "UsersPage";
        public const string AddUserPage = "AddUserPage";

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     The default constructor.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Register view models.
            SimpleIoc.Default.Register<UsersPageViewModel>();
            SimpleIoc.Default.Register<AddUserPageViewModel>();
        }

        #endregion

        /// <summary>
        ///     The user page view model.
        /// </summary>
        public UsersPageViewModel UsersPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UsersPageViewModel>();
            }
        }

        /// <summary>
        ///     The user page view model.
        /// </summary>
        public AddUserPageViewModel AddUserPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddUserPageViewModel>();
            }
        }

        /// <summary>
        ///     Clean up view models.
        /// </summary>
        public static void Cleanup()
        {
            
        }

        #endregion
    }
}