//using MVC_And_Angular.ApiControllers;
//using MVC_And_Angular.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace MVC_And_Angular.ApiControllers
//{
//    public class SuppliersApiController : ApiController
//    {
//        [HttpPost]
//        public HttpResponseMessage PostSupplier(Supplier supplier)
//        {
//            try
//            {
//                if (!ModelState.IsValid)
//                {

//                    var error = ModelState.Where(ms => ms.Value.Errors.Any())
//                        .Select(ms => new { Message = ms.Value.Errors[0].ErrorMessage })
//                        .FirstOrDefault();

//                    return Request.CreateResponse(HttpStatusCode.BadRequest, error);
//                    //throw  new Exception("missing requierd field");

//                }
//                NorthwindEntities db = new NorthwindEntities();
//                db.Suppliers.Add(supplier);
                

//                db.SaveChanges();
//                return Request.CreateResponse(HttpStatusCode.Created);

//            }
//            catch (Exception ex)
//            {

//                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
//            }

//        }

//    }
//}
