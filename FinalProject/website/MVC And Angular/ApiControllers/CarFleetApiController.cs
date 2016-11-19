using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data_Access_Layer;

namespace MVC_And_Angular.ApiControllers
{
    public class CarFleetApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage AddNewCar(CarFleet Car)
        {
            try
            {
                PeretzRentsEntities db = new PeretzRentsEntities();

                db.AddCarToCarFleet(Car.CarID, Car.CarModelID, Car.Mileage, Car.Photo, Car.ReadyForRental, Car.IsDelete);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        //[HttpPost]
        //public HttpResponseMessage DeleteCar(CarFleet Car)
        //{
        //    try
        //    {
        //        PeretzRentsEntities db = new PeretzRentsEntities();
        //        db.DeleteCarFormFleet(Car.CarID);
                
        //        db.SaveChanges();
        //        return Request.CreateResponse(HttpStatusCode.Created);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}
        public IHttpActionResult GetCar(CarFleet Car)
        {
            if (Car == null)
            {
                return NotFound();
            }
            return Ok(Car);
        }
    }
}
