using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data_Access_Layer;

namespace MVC_And_Angular.ApiControllers
{
    public class CarModelApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage PostProduct(CarFleet Car)
        {
            try
            {
                PeretzRentsEntities db = new PeretzRentsEntities();

                db.CarFleets.Add(Car);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
