#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using Android.App;
using Android.OS;
using Android.Widget;
using CharterCodingTest.ViewModel;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace CharterCodingTest.Activities
{
    ///<summary>
    ///    The add user page activity.
    ///</summary>
    [Activity(Label = "AddUserPageActivity")]
    public class AddUserPageActivity : ActivityBase
    {
        #region Fields

        private Button _addUserButton;
        private Button _cancelButton;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the view model.
        /// </summary>
        private AddUserPageViewModel ViewModel
        {
            get
            {
                return App.Locator.AddUserPageViewModel;
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
                   ?? (_addUserButton = FindViewById<Button>(Resource.Id.addUserButton));
            }
        }

        ///<summary>
        ///    The cancel button.
        ///</summary>
        public Button CancelButton
        {
            get
            {
                return _cancelButton
                  ?? (_cancelButton = FindViewById<Button>(Resource.Id.cancelButton));
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
            SetContentView(Resource.Layout.AddUserPage);

            // Binding
            AddUserButton.SetCommand("Click", ViewModel.AddUserCommand);
            CancelButton.SetCommand("Click", ViewModel.CancelCommand);
        }

        #endregion
    }
}