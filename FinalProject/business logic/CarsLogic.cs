using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic
{
    /// <summary>
    /// Cars logic - contains logic for the Cars in the CarsModels table.
    /// </summary>
    class CarsLogic : BaseLogic
    {

        public List<Car> GetAllCars()
        {
            try
            {
                //TODO - remember to add a "where" IsDeleted = false, this will be used for "delete" cars.
                //return DB.CarFleets.Select(car => car.CarID).ToArray();
                var query = DB.SelectAllCarsIsNotDeleted();
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
            catch (Exception)
            {

                throw;
            }
        }

        public void AddCar( string CarID, int CarModelID, int Mileage, string Photo, bool ReadyForRental)
        {
            try
            {
                DB.AddCarToCarFleet(CarID, CarModelID, Mileage, Photo, ReadyForRental, false);

            }
            catch (Exception)
            {

                throw;
            }
            
            //TODO - waiting for stored procedure from Assaf.
        }

        public void UpdateCar(string CarID, int CarModelID, int Mileage, string Photo, bool ReadyForRental)
        {
            //TODO - waiting for stored procedure from Assaf.
            try
            {
                DB.UpdateCarFeelt(CarID, CarModelID, Mileage, Photo, ReadyForRental);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void DeleteCar(string CarID)
        {
            try
            {
                DB.DeleteCarFormFleet(CarID);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public string[] GetAllCarManufacture()
        {
            try
            {
               return DB.Manufactures.Select(M => M.ManufacturerName).ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddManufacturer(string manufactureName)
        {
            try
            {
                DB.AddManufacturer(manufactureName);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateManufacture(int manufactureID, string manufactureName)
        {
            try
            {
                DB.UpdateManufacturer(manufactureID, manufactureName);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int[] GetAllCarModels()
        {
            try
            {
                return DB.CarsModels.Select(modle => modle.CarModelID).ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddCarModel(int manufacturerID,string carModel,int manufactureYear,string transmission,decimal dailyRate,decimal lateFee)
        {
            DB.AddCarModel(manufacturerID, carModel, manufactureYear, transmission, dailyRate, lateFee);
        }

        public void UpdateCarModel(int carModelID, int manufacturerID, string carModel, int manufactureYear, string transmission, decimal dailyRate, decimal lateFee)
        {
            DB.UpdateCarModel(carModelID,manufacturerID, carModel, manufactureYear, transmission, dailyRate, lateFee);
        }

        





    }
}
