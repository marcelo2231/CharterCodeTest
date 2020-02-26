#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using Android.App;
using Android.OS;
using Android.Widget;
using CharterCodingTest.Validation;
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
        private EditText _firstNameEditText;
        private EditText _lastNameEditText;
        private EditText _ageEditText;
        private EditText _usernameEditText;
        private EditText _passwordEditText;

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


        ///<summary>
        ///    The first name edit text.
        ///</summary>
        public EditText FirstNameEditText
        {
            get
            {
                return _firstNameEditText
                  ?? (_firstNameEditText = FindViewById<EditText>(Resource.Id.firstNameEntry));
            }
        }

        ///<summary>
        ///    The last name edit text.
        ///</summary>
        public EditText LastNameEditText
        {
            get
            {
                return _lastNameEditText
                  ?? (_lastNameEditText = FindViewById<EditText>(Resource.Id.lastNameEntry));
            }
        }

        ///<summary>
        ///    The age edit text.
        ///</summary>
        public EditText AgeEditText
        {
            get
            {
                return _ageEditText
                  ?? (_ageEditText = FindViewById<EditText>(Resource.Id.ageEntry));
            }
        }

        ///<summary>
        ///    The username edit text.
        ///</summary>
        public EditText UsernameEditText
        {
            get
            {
                return _usernameEditText
                  ?? (_usernameEditText = FindViewById<EditText>(Resource.Id.usernameEntry));
            }
        }

        ///<summary>
        ///    The password edit text.
        ///</summary>
        public EditText PasswordEditText
        {
            get
            {
                return _passwordEditText
                  ?? (_passwordEditText = FindViewById<EditText>(Resource.Id.passwordEntry));
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

            // Add Validations
            var validationHelper = new UserValidation();

            // I would usually use a ValidatableObject<string>, add Validation collections and rules,
            // and have a ValidatableEntryControl with bindable properties which would display an error
            // message and turn red when invalid. I have that set up on one of my side projects (Xamarin.Forms)
            //  and I can send a link to it. But since I am not familiar with Xamarin.Android, only .Forms,
            // I would expend a quite a few time on it, since even on forms this
            // is a little time consuming, which is probably outside of the scope of this project/test.

            PasswordEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                ViewModel.User.Password = PasswordEditText.Text;

                if (!validationHelper.ValidatePasswordNullOrWhiteSpace(PasswordEditText.Text))
                {
                    PasswordEditText.SetError(Resources.GetString(Resource.String.passwordNullValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
                else if(!validationHelper.ValidatePassword(PasswordEditText.Text))
                {
                    PasswordEditText.SetError(Resources.GetString(Resource.String.passwordValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
                else if (!validationHelper.ValidatePasswordLength(PasswordEditText.Text))
                {
                    PasswordEditText.SetError(Resources.GetString(Resource.String.passwordLengthValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
                else if (!validationHelper.ValidatePasswordSequence(PasswordEditText.Text))
                {
                    PasswordEditText.SetError(Resources.GetString(Resource.String.passwordSequenceValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }

            };

            UsernameEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                ViewModel.User.Username = UsernameEditText.Text;
                if (!validationHelper.ValidateUsername(UsernameEditText.Text))
                {
                    UsernameEditText.SetError(Resources.GetString(Resource.String.usernameValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
            };

            FirstNameEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                ViewModel.User.FirstName = FirstNameEditText.Text;
                if (!validationHelper.ValidateFirstName(FirstNameEditText.Text))
                {
                    FirstNameEditText.SetError(Resources.GetString(Resource.String.firstNameValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
            };

            LastNameEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                ViewModel.User.LastName = LastNameEditText.Text;
                if (!validationHelper.ValidateLastName(LastNameEditText.Text))
                {
                    LastNameEditText.SetError(Resources.GetString(Resource.String.lastNameValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
            };

            AgeEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                ViewModel.User.Age = AgeEditText.Text;
                if (!validationHelper.ValidateAge(AgeEditText.Text))
                {
                    AgeEditText.SetError(Resources.GetString(Resource.String.ageValidationError),
                        Resources.GetDrawable(Resource.Drawable.error));
                }
            };
        }

        #endregion
    }
}