using System.Linq;
using System.Web.Security;
using Data_Access_Layer;
using System;

#pragma warning disable 618

// Need to add reference to: System.Web (Framework 4.0)

namespace Business_Logic
{
    /// <summary>
    /// Users logic - contains logic for the users table.
    /// </summary>
    public class UsersLogic : BaseLogic
    {
        /// <summary>
        /// Register new user.
        /// </summary>
        /// <param name="username">The user's username.</param>
        /// <param name="password">The user's password.</param>
                //public void Register(string username, string password, string firstName,, string lastName, string id, string email, DateTime dateOfBirth, string phone, string mobile)
        public void Register(User user)
        {
            string encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "sha1");
            //User user = new User { Username = username, Password = encryptPassword, FirstName = firstName, LastName = lastName, ID = id, EMail = email, DateOfBirth = dateOfBirth, Phone = phone, Mobile = mobile };
            DB.Roles.FirstOrDefault(r => r.RoleID == 3).Users.Add(user); // Set this user the "User" Role (RoleID = 3).
            DB.Users.Add(user);
            DB.SaveChanges();
        }

        /// <summary>
        /// Check if username already taken.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns>Returns true if username already taken.</returns>
        public bool IsUsernameTaken(string username)
        {
            return DB.Users.Any(u => u.Username == username);
        }

        /// <summary>
        /// Check if user exists.
        /// </summary>
        /// <param name="username">The user's username.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>Returns true if user exist.</returns>
        public bool IsUserExist(string username, string password)
        {
            string encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1");
            return DB.Users.Any(u => u.Username == username && u.Password == encryptPassword);
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns>Returns all usernames.</returns>
        public string[] GetAllUsers()
        {
            return DB.Users.Select(u => u.Username).ToArray();
        }
    }
}