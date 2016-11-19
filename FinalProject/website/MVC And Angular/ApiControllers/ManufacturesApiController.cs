using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data_Access_Layer;
using Business_Logic;
using System.Linq;

namespace MVC_And_Angular.ApiControllers
{
    public class ManufacturesApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage PostManufacturer(Manufacture manufacturer)
        {
            try
            {
                PeretzRentsEntities db = new PeretzRentsEntities();

                db.AddManufacturer(manufacturer.ManufacturerName);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetManufacturer(int id)
        {
            PeretzRentsEntities db = new PeretzRentsEntities();

            var manufacturer = db.Manufactures.FirstOrDefault((p => p.ManufacturerID == id));

            if (manufacturer == null)
            {
                return NotFound();
            }
            return Ok(manufacturer);
        }
    }
}
