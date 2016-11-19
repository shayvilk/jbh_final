using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Data_Access_Layer;
using Business_Logic;

namespace MVC_And_Angular
{
    /// <summary>
    /// Summary description for ProductsService
    /// </summary>
    public class TestService: IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json"; // MIME TYPE

            PeretzRentsEntities DB = new PeretzRentsEntities();

            //var  = db.Products.Select(p => new {
            //    productID = p.ProductID,
            //    productName = p.ProductName, 
            //    unitPrice = p.UnitPrice,
            //    unitsInStock = p.UnitsInStock,
            //    unitsOnOrder = p.UnitsOnOrder
            //});

            var query = DB.SelectAllCarsIsNotDeleted();
            List<Car> carList = new List<Car>();

            foreach (var item in query)
            {
                Car car = new Car();
                car.Mileage = item.Mileage;
                car.CarModel = item.CarModel;
                car.Photo = item.Photo;
                car.Transmission = item.Transmission;
                car.ManufacturerName = item.ManufacturerName;
                carList.Add(car);
            }

            // JSON Formatter: 
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();

            string json = jsSerializer.Serialize(carList);

            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}