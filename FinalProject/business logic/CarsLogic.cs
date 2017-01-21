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
        #region AllAboutCars

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
                    car.ReadyForRental = item.ReadyForRental;
                    carList.Add(car);
                }
                return carList;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddNewCar(string CarID, int CarModelID, int Mileage, string Photo, bool ReadyForRental)
        {
            var checkIfExist = DB.CarFleets.Where(p => p.CarID == CarID).FirstOrDefault();
            try
            {
                if (checkIfExist == null)
                {
                    DB.AddCarToCarFleet(CarID, CarModelID, Mileage, Photo, ReadyForRental, false);
                    return true;
                }
                return false;
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
            var query = DB.CarFleets.Where(s => s.CarID == CarID).FirstOrDefault();

            try
            {
                if (query != null)
                DB.DeleteCarFormFleet(CarID);
            }
            catch (Exception)
            {
                throw;
            }


        }

        public bool ReturnCarAndChangeToReadyForRent(string CarID)
        {
            var query = DB.CarFleets.Where(s => s.CarID == CarID).FirstOrDefault();

            if (query != null)
            {
                query.ReadyForRental = true;

                DB.SaveChanges();

                return true;
            }
            return false;
        }



        #endregion

        #region AllAboutManufacturers

        public List<Manufacturer> GetAllCarManufacture()
        {
            var query = DB.SelectAllManufacturers();

            List<Manufacturer> manufacturerList = null;
            try
            {
                foreach (var item in query)
                {
                    Manufacturer manufacturer = new Manufacturer();
                    manufacturer.ManufacturerID = item.ManufacturerID;
                    manufacturer.ManufacturerName = item.ManufacturerName;
                    manufacturerList.Add(manufacturer);
                }
                return manufacturerList;
            }

            catch (Exception)
            {

                throw;
            }
        }

        public bool AddManufacturer(string manufactureName)
        {
            try
            {
                var checkIfExist = DB.Manufactures.Where(m => m.ManufacturerName == manufactureName).FirstOrDefault();

                if (checkIfExist == null)
                {
                    DB.AddManufacturer(manufactureName);
                    return true;
                }
                return false;
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
                var checkIExist = DB.Manufactures.Where(m => m.ManufacturerName == manufactureName).FirstOrDefault();

                if (checkIExist == null)
                {
                    DB.UpdateManufacturer(manufactureID, manufactureName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteManufacturer(int manufactureID)
        {
            var query = DB.Manufactures.Where(s => s.ManufacturerID == manufactureID).FirstOrDefault();

            if (query != null)
            {
                query.IsDelete = true;

                var carsModelsQuery = DB.CarsModels.Where(p => p.ManufacturerID == query.ManufacturerID).ToList();

                if (carsModelsQuery != null)
                {
                    foreach (var item in carsModelsQuery)
                    {
                        item.IsDelete = true;

                        var carQuery = DB.CarFleets.Where(x => x.CarModelID == item.CarModelID).FirstOrDefault();

                        if (carQuery != null)
                        {
                            carQuery.ReadyForRental = false;
                            carQuery.IsDelete = true;
                        }
                    }
                }

                DB.SaveChanges();
            }
        }
        #endregion

        #region CarModels
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

        #endregion





    }
}
