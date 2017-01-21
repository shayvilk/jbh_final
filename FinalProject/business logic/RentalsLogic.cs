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
        //public List<Rental> GetAllRentals()
        //{
        //        var thisList = DB.Rentals.Where(r => r.CarRentalID > 0).ToList();
        //    return thisList;
        //}
        public List<RentalOrder> GetAllRentals()
        {
            try
            {
                var query = DB.GetAllRentals();
                List<RentalOrder> rentalList = null;

                foreach (var item in query)
                {
                    RentalOrder rentalOrder = new RentalOrder();
                    rentalOrder.CarRentalID = item.CarRentalID;
                    rentalOrder.CarID = item.CarID   ;
                    rentalOrder.UserID = item.UserID;
                    rentalOrder.RentalStartDate = item.RentalStartDate;
                    rentalOrder.RentalFinishDate = item.RentalFinishDate;
                    rentalOrder.RentalActualFinishDate = item.RentalActualFinishDate;
                    rentalList.Add(rentalOrder);
                }
                return rentalList;


            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<RentalOrder> GetRentalsByUser(int userID)
        {
            try
            {
                var query = DB.GetRentalsByUser(userID);
                List<RentalOrder> rentalList = null;

                foreach (var item in query)
                {
                    RentalOrder rentalOrder = new RentalOrder();
                    rentalOrder.CarRentalID = item.CarRentalID;
                    rentalOrder.CarID = item.CarID;
                    rentalOrder.UserID = item.UserID;
                    rentalOrder.RentalStartDate = item.RentalStartDate;
                    rentalOrder.RentalFinishDate = item.RentalFinishDate;
                    rentalOrder.RentalActualFinishDate = item.RentalActualFinishDate;
                    rentalOrder.IsCancelled = item.IsCancelled;
                    rentalList.Add(rentalOrder);
                }
                return rentalList;


            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool CancelOrder(int carRentalID)
        {
            var query = DB.Rentals.Where(s => s.CarRentalID == carRentalID).FirstOrDefault();

            if (query != null)
            {
                query.IsCancelled = true;

                DB.SaveChanges();

                return true;
            }
            return false;
        }

        public void AddRental(string carID, int userID, DateTime rentalStartDate, DateTime rentalFinishDate, DateTime? rentalActualDate)
        {
            try
            {
                DB.AddRental(carID, userID, rentalStartDate, rentalFinishDate, rentalActualDate);

            }
            catch (Exception ex)
            {
                throw;
            }

        
        }

        public void UpdateRental(int CarRentalID, string CarID, int userID, DateTime rentalStartDate, DateTime rentalFinishDate, DateTime? rentalActualDate)
        {
  
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

