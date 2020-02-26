#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion
namespace CharterCodingTest.Models
{
    /// <summary>
    ///     The user model.
    /// </summary>
    public class UserModel
    {
        #region Properties

        /// <summary>
        ///     Gets/sets the user id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Gets/sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     Gets/sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///     Gets/sets the user first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Gets/sets the user last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     Gets/sets the user age.
        /// </summary>
        public string Age { get; set; }

        #endregion
    }
}