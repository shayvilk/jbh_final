using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data_Access_Layer;
using Business_Logic;

namespace MVC_And_Angular.ApiControllers
{
    public class CarOrdersApiController : ApiController
    {
        PeretzRentsEntities DB = new PeretzRentsEntities();
        [HttpPost]
        public HttpResponseMessage PostOrder(RentalOrder order)
        {
            try
            {
                RentalsLogic rentalsLogic = new RentalsLogic();
                rentalsLogic.AddRental(order.CarID, order.UserID, order.RentalStartDate,order.RentalFinishDate, order.RentalActualFinishDate);
                //DB.AddRental();

                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetOrder(Rental order)
        {
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
        //public IHttpActionResult GetOrders()
        //{
        //    RentalsLogic rentalLogic = new RentalsLogic();
        //    return Ok(rentalLogic.GetAllRentals());
        //}
        //public IHttpActionResult GetAllRentals()
        //{
        //    //if (Car == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    RentalsLogic rentalsLogic = new RentalsLogic();
        //    return Ok(rentalsLogic.GetAllRentals());
        //}
        [HttpGet]
        public IHttpActionResult GetCB_GetAllRentals()
        {
            try
            {
                RentalsLogic rentalLogic = new RentalsLogic();
                return Ok(rentalLogic.GetAllRentals());
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

    }
}
