#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using Android.Widget;
using Java.Lang;

namespace CharterCodingTest.Adapters
{
    /// <summary>
    ///     The user view holder.
    /// </summary>
    public class UserViewHolder : Object
    {
        #region Properties

        /// <summary>
        ///     Gets/sets the first name view.
        /// </summary>
        public TextView firstNameView { get; set; }

        /// <summary>
        ///     Gets/sets the last name view.
        /// </summary>
        public TextView lastNameView { get; set; }

        /// <summary>
        ///     Gets/sets the username view.
        /// </summary>
        public TextView usernameView { get; set; }

        /// <summary>
        ///     Gets/sets the age view.
        /// </summary>
        public TextView ageView { get; set; }

        #endregion
    }
}