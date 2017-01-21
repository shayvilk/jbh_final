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
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="idNumber"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="birthDate"></param>
                //public void Register(string username, string password, string firstName,, string lastName, string id, string email, DateTime dateOfBirth, string phone, string mobile)
        public void Register(string firstName, string lastName, string id,string username, string password, string email, DateTime birthDate)
        {
            string encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "sha1");
            //User user = new User { Username = username, Password = encryptPassword, FirstName = firstName, LastName = lastName, ID = id, EMail = email, DateOfBirth = dateOfBirth, Phone = phone, Mobile = mobile };
            User user = new User {
                FirstName = firstName,
                LastName = lastName,
                ID = id,
                RoleID = 3,// default role
                Username = username,
                Password = encryptPassword,
                EMail = email,
                DateOfBirth = birthDate
            };
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