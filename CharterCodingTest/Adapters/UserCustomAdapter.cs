#region Copyright

// ==================================================================================================
//   This file is part of the Charter Coding Test application.
//   Copyright ©2020 Archiza. All rights reserved.
// ==================================================================================================

#endregion

using Android.App;
using Android.Views;
using Android.Widget;
using CharterCodingTest.Models;
using Java.Lang;
using System.Collections.Generic;

namespace CharterCodingTest.Adapters
{
    /// <summary>
    ///     The add user custom adapter.
    /// </summary>
    public class UserCustomAdapter : BaseAdapter
    {
        #region Fields

        private Activity activity;
        private List<UserModel> users;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets/sets the count.
        /// </summary>
        public override int Count { get { return users.Count; } }

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     The default constructor.
        /// </summary>
        public UserCustomAdapter(Activity activity, List<UserModel> users)
        {
            this.activity = activity;
            this.users = users;
        }

        #endregion

        /// <summary>
        ///     Gets an item.
        /// </summary>
        public override Object GetItem(int position)
        {
            return null;
        }

        /// <summary>
        ///     Gets item Id.
        /// </summary>
        public override long GetItemId(int position)
        {
            return users[position].Id;
        }

        /// <summary>
        ///     Gets a view.
        /// </summary>
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.UserListViewItem, parent, false);
            var firstNameView = view.FindViewById<TextView>(Resource.Id.firstNameTextView);
            var lastNameView = view.FindViewById<TextView>(Resource.Id.lastNameTextView);
            var usernameView = view.FindViewById<TextView>(Resource.Id.usernameTextView);
            var ageView = view.FindViewById<TextView>(Resource.Id.ageTextView);

            firstNameView.Text = users[position].FirstName;
            lastNameView.Text = users[position].LastName;
            usernameView.Text = users[position].Username;
            ageView.Text = users[position].Age;

            return view;
        }

        #endregion
    }
}