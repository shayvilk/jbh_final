using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data_Access_Layer;

namespace MVC_And_Angular.ApiControllers
{
    public class LoginApiController : ApiController
    {
        // GET: /Login/  

        PeretzRentsEntities DB = new PeretzRentsEntities();
        [HttpPost]
        public HttpResponseMessage Login(User user)
        {
            bool isPasswordCorrect = false;
            string un = data.Username;
            string Password = data.Password;
            using (SahilEntities entity = new SahilEntities())
            {
                var user = entity.Logins1.Where(u => u.UserName == un).FirstOrDefault();
                if (user != null)
                {
                    if (Password == user.Password)
                    {
                        Session["LoginID"] = user.ID;
                        Session["Username"] = user.Fname + ' ' + user.Lname;
                        return user.ID.ToString();
                    }
                    else
                    {
                        return "0";
                    }
                }
                else
                {
                    return "-1";
                }
            }
        }

    }

}