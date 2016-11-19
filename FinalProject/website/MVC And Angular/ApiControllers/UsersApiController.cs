using Business_Logic;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_And_Angular.ApiControllers
{
    public class UsersApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage PostUser(User user)
        {
            try
            {
                //PeretzRentsEntities db = new PeretzRentsEntities();
                UsersLogic usersLogic = new UsersLogic();
                usersLogic.Register(user);
                //db.Users.Add(user);
                //db.AddManufacturer(manufacturer.ManufacturerName);
                return Request.CreateResponse(HttpStatusCode.Created);
                //return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetUser(int id)
        {
            PeretzRentsEntities db = new PeretzRentsEntities();

            var user = db.Users.FirstOrDefault((p => p.UserID == id));

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
