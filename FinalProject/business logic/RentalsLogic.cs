using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using System.Net;

namespace Business_Logic
{
    /// <summary>
    /// Rentals logic - contains logic for the Rentals table.
    /// </summary>
    public class RentalsLogic : BaseLogic
    {
        public List<Rental> GetAllRentals()
        {
                var thisList = DB.Rentals.Where(r => r.CarRentalID > 0).ToList();
            return thisList;
        }

        //        public void AddRental(string CarID, int userID, DateTime rentalStartDate, DateTime rentalFinishDate, DateTime rentalActualDate)

        public void AddRental(string carID, int userID, DateTime rentalStartDate, DateTime rentalFinishDate, DateTime rentalActualDate)
        {
            try
            {
                DB.AddRental(carID, userID, rentalStartDate, rentalFinishDate, rentalActualDate);

            }
            catch (Exception ex)
            {
                throw;
            }

            //TODO - waiting for stored procedure from Assaf.
        }

        public void UpdateRental(int CarRentalID, string CarID, int userID, DateTime rentalStartDate, DateTime rentalFinishDate, DateTime rentalActualDate)
        {
            //TODO - waiting for stored procedure from Assaf.
            try
            {
                DB.UpdateRentals(CarRentalID, CarID, userID, rentalStartDate, rentalFinishDate, rentalActualDate);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Car> GetAvilableCars(DateTime startDate, DateTime finishDate)
        {
            var query = DB.CheckAvailability(startDate, finishDate);
            List<Car> carList = null;

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
            return carList;
        }


    }
}

