#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using System.Text.RegularExpressions;

namespace CharterCodingTest.Validation
{
    ///<summary>
    ///    The user validation helper class.
    ///</summary>
    public class UserValidation
    {
        #region Methods

        ///<summary>
        ///    Validates the password to see if it is null or white space.
        ///</summary>
        public bool ValidatePasswordNullOrWhiteSpace(string password)
        {
            return !string.IsNullOrWhiteSpace(password);
        }

        ///<summary>
        ///    Validates the password characters.
        ///</summary>
        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])";
            var regex = new Regex(pattern);
            return regex.IsMatch(password);
        }

        ///<summary>
        ///    Validates the password legth.
        ///</summary>
        public bool ValidatePasswordLength(string password)
        {
            string pattern = @".{5,12}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(password);
        }

        ///<summary>
        ///    Validates if password has any repeated sequence.
        ///</summary>
        public bool ValidatePasswordSequence(string password)
        {
            string pattern = @"(...+)\1";
            var regex = new Regex(pattern);
            return !regex.IsMatch(password);
        }

        ///<summary>
        ///    Validates the username.
        ///</summary>
        public bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            string pattern = @"[A-Za-z].{4,16}$";
            var regex = new Regex(pattern);
            return regex.IsMatch(username);
        }

        ///<summary>
        ///    Validates the first name.
        ///</summary>
        public bool ValidateFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                return false;
            }

            string pattern = @"[A-Za-z]";
            var regex = new Regex(pattern);
            return regex.IsMatch(firstName);
        }

        ///<summary>
        ///    Validates the last name.
        ///</summary>
        public bool ValidateLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

            string pattern = @"[A-Za-z]";
            var regex = new Regex(pattern);
            return regex.IsMatch(lastName);
        }

        ///<summary>
        ///    Validates the age.
        ///</summary>
        public bool ValidateAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age))
            {
                return false;
            }

            string pattern = @"[0-9]";
            var regex = new Regex(pattern);
            return regex.IsMatch(age);
        }

        #endregion
    }
}