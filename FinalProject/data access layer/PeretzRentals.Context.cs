﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PeretzRentsEntities : DbContext
    {
        public PeretzRentsEntities()
            : base("name=PeretzRentsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarFleet> CarFleets { get; set; }
        public virtual DbSet<CarsModel> CarsModels { get; set; }
        public virtual DbSet<Manufacture> Manufactures { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int AddCarModel(Nullable<int> manufacturerID, string carModel, Nullable<int> manufactureYear, string transmission, Nullable<decimal> dailyRate, Nullable<decimal> lateFee)
        {
            var manufacturerIDParameter = manufacturerID.HasValue ?
                new ObjectParameter("manufacturerID", manufacturerID) :
                new ObjectParameter("manufacturerID", typeof(int));
    
            var carModelParameter = carModel != null ?
                new ObjectParameter("carModel", carModel) :
                new ObjectParameter("carModel", typeof(string));
    
            var manufactureYearParameter = manufactureYear.HasValue ?
                new ObjectParameter("manufactureYear", manufactureYear) :
                new ObjectParameter("manufactureYear", typeof(int));
    
            var transmissionParameter = transmission != null ?
                new ObjectParameter("transmission", transmission) :
                new ObjectParameter("transmission", typeof(string));
    
            var dailyRateParameter = dailyRate.HasValue ?
                new ObjectParameter("dailyRate", dailyRate) :
                new ObjectParameter("dailyRate", typeof(decimal));
    
            var lateFeeParameter = lateFee.HasValue ?
                new ObjectParameter("lateFee", lateFee) :
                new ObjectParameter("lateFee", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCarModel", manufacturerIDParameter, carModelParameter, manufactureYearParameter, transmissionParameter, dailyRateParameter, lateFeeParameter);
        }
    
        public virtual int AddCarToCarFleet(string carID, Nullable<int> carModelID, Nullable<int> mileage, string photo, Nullable<bool> readyForRental, Nullable<bool> isDelete)
        {
            var carIDParameter = carID != null ?
                new ObjectParameter("carID", carID) :
                new ObjectParameter("carID", typeof(string));
    
            var carModelIDParameter = carModelID.HasValue ?
                new ObjectParameter("carModelID", carModelID) :
                new ObjectParameter("carModelID", typeof(int));
    
            var mileageParameter = mileage.HasValue ?
                new ObjectParameter("mileage", mileage) :
                new ObjectParameter("mileage", typeof(int));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            var readyForRentalParameter = readyForRental.HasValue ?
                new ObjectParameter("readyForRental", readyForRental) :
                new ObjectParameter("readyForRental", typeof(bool));
    
            var isDeleteParameter = isDelete.HasValue ?
                new ObjectParameter("isDelete", isDelete) :
                new ObjectParameter("isDelete", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCarToCarFleet", carIDParameter, carModelIDParameter, mileageParameter, photoParameter, readyForRentalParameter, isDeleteParameter);
        }
    
        public virtual int AddManufacturer(string manufacturerName)
        {
            var manufacturerNameParameter = manufacturerName != null ?
                new ObjectParameter("manufacturerName", manufacturerName) :
                new ObjectParameter("manufacturerName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddManufacturer", manufacturerNameParameter);
        }
    
        public virtual int AddRental(string carID, Nullable<int> userID, Nullable<System.DateTime> rentalStartDate, Nullable<System.DateTime> rentalFinishDate, Nullable<System.DateTime> rentalActualDate)
        {
            var carIDParameter = carID != null ?
                new ObjectParameter("carID", carID) :
                new ObjectParameter("carID", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var rentalStartDateParameter = rentalStartDate.HasValue ?
                new ObjectParameter("rentalStartDate", rentalStartDate) :
                new ObjectParameter("rentalStartDate", typeof(System.DateTime));
    
            var rentalFinishDateParameter = rentalFinishDate.HasValue ?
                new ObjectParameter("rentalFinishDate", rentalFinishDate) :
                new ObjectParameter("rentalFinishDate", typeof(System.DateTime));
    
            var rentalActualDateParameter = rentalActualDate.HasValue ?
                new ObjectParameter("rentalActualDate", rentalActualDate) :
                new ObjectParameter("rentalActualDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRental", carIDParameter, userIDParameter, rentalStartDateParameter, rentalFinishDateParameter, rentalActualDateParameter);
        }
    
        public virtual int UpdateCarFeelt(string carID, Nullable<int> carModelID, Nullable<int> mileage, string photo, Nullable<bool> readyForRental)
        {
            var carIDParameter = carID != null ?
                new ObjectParameter("carID", carID) :
                new ObjectParameter("carID", typeof(string));
    
            var carModelIDParameter = carModelID.HasValue ?
                new ObjectParameter("carModelID", carModelID) :
                new ObjectParameter("carModelID", typeof(int));
    
            var mileageParameter = mileage.HasValue ?
                new ObjectParameter("mileage", mileage) :
                new ObjectParameter("mileage", typeof(int));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            var readyForRentalParameter = readyForRental.HasValue ?
                new ObjectParameter("readyForRental", readyForRental) :
                new ObjectParameter("readyForRental", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCarFeelt", carIDParameter, carModelIDParameter, mileageParameter, photoParameter, readyForRentalParameter);
        }
    
        public virtual int UpdateCarModel(Nullable<int> carModelID, Nullable<int> manufacturerID, string carModel, Nullable<int> manufactureYear, string transmission, Nullable<decimal> dailyRate, Nullable<decimal> lateFee)
        {
            var carModelIDParameter = carModelID.HasValue ?
                new ObjectParameter("carModelID", carModelID) :
                new ObjectParameter("carModelID", typeof(int));
    
            var manufacturerIDParameter = manufacturerID.HasValue ?
                new ObjectParameter("manufacturerID", manufacturerID) :
                new ObjectParameter("manufacturerID", typeof(int));
    
            var carModelParameter = carModel != null ?
                new ObjectParameter("carModel", carModel) :
                new ObjectParameter("carModel", typeof(string));
    
            var manufactureYearParameter = manufactureYear.HasValue ?
                new ObjectParameter("manufactureYear", manufactureYear) :
                new ObjectParameter("manufactureYear", typeof(int));
    
            var transmissionParameter = transmission != null ?
                new ObjectParameter("transmission", transmission) :
                new ObjectParameter("transmission", typeof(string));
    
            var dailyRateParameter = dailyRate.HasValue ?
                new ObjectParameter("dailyRate", dailyRate) :
                new ObjectParameter("dailyRate", typeof(decimal));
    
            var lateFeeParameter = lateFee.HasValue ?
                new ObjectParameter("lateFee", lateFee) :
                new ObjectParameter("lateFee", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCarModel", carModelIDParameter, manufacturerIDParameter, carModelParameter, manufactureYearParameter, transmissionParameter, dailyRateParameter, lateFeeParameter);
        }
    
        public virtual int UpdateManufacturer(Nullable<int> manufacturerID, string manufacturerName)
        {
            var manufacturerIDParameter = manufacturerID.HasValue ?
                new ObjectParameter("manufacturerID", manufacturerID) :
                new ObjectParameter("manufacturerID", typeof(int));
    
            var manufacturerNameParameter = manufacturerName != null ?
                new ObjectParameter("manufacturerName", manufacturerName) :
                new ObjectParameter("manufacturerName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateManufacturer", manufacturerIDParameter, manufacturerNameParameter);
        }
    
        public virtual int UpdateRentals(Nullable<int> carRentalID, string carID, Nullable<int> userID, Nullable<System.DateTime> rentalStartDate, Nullable<System.DateTime> rentalFinishDate, Nullable<System.DateTime> rentelActualFinishDate)
        {
            var carRentalIDParameter = carRentalID.HasValue ?
                new ObjectParameter("carRentalID", carRentalID) :
                new ObjectParameter("carRentalID", typeof(int));
    
            var carIDParameter = carID != null ?
                new ObjectParameter("carID", carID) :
                new ObjectParameter("carID", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var rentalStartDateParameter = rentalStartDate.HasValue ?
                new ObjectParameter("rentalStartDate", rentalStartDate) :
                new ObjectParameter("rentalStartDate", typeof(System.DateTime));
    
            var rentalFinishDateParameter = rentalFinishDate.HasValue ?
                new ObjectParameter("rentalFinishDate", rentalFinishDate) :
                new ObjectParameter("rentalFinishDate", typeof(System.DateTime));
    
            var rentelActualFinishDateParameter = rentelActualFinishDate.HasValue ?
                new ObjectParameter("rentelActualFinishDate", rentelActualFinishDate) :
                new ObjectParameter("rentelActualFinishDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateRentals", carRentalIDParameter, carIDParameter, userIDParameter, rentalStartDateParameter, rentalFinishDateParameter, rentelActualFinishDateParameter);
        }
    
        public virtual ObjectResult<CheckAvailability_Result> CheckAvailability(Nullable<System.DateTime> startTime, Nullable<System.DateTime> endTime)
        {
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("startTime", startTime) :
                new ObjectParameter("startTime", typeof(System.DateTime));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("endTime", endTime) :
                new ObjectParameter("endTime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CheckAvailability_Result>("CheckAvailability", startTimeParameter, endTimeParameter);
        }
    
        public virtual int DeleteCarFormFleet(string carID)
        {
            var carIDParameter = carID != null ?
                new ObjectParameter("carID", carID) :
                new ObjectParameter("carID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCarFormFleet", carIDParameter);
        }
    
        public virtual int DeleteCarModel(Nullable<int> carModelID)
        {
            var carModelIDParameter = carModelID.HasValue ?
                new ObjectParameter("carModelID", carModelID) :
                new ObjectParameter("carModelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCarModel", carModelIDParameter);
        }
    
        public virtual int DeleteManufacturer(Nullable<int> manufcaturerID)
        {
            var manufcaturerIDParameter = manufcaturerID.HasValue ?
                new ObjectParameter("manufcaturerID", manufcaturerID) :
                new ObjectParameter("manufcaturerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteManufacturer", manufcaturerIDParameter);
        }
    
        public virtual ObjectResult<SelectAllCars_Result> SelectAllCars()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllCars_Result>("SelectAllCars");
        }
    
        public virtual ObjectResult<SelectAllCarsIsNotDeleted_Result> SelectAllCarsIsNotDeleted()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllCarsIsNotDeleted_Result>("SelectAllCarsIsNotDeleted");
        }
    
        public virtual ObjectResult<GetAllRentals_Result> GetAllRentals()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllRentals_Result>("GetAllRentals");
        }
    
        public virtual ObjectResult<SelectAllManufacturers_Result> SelectAllManufacturers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllManufacturers_Result>("SelectAllManufacturers");
        }
    
        public virtual ObjectResult<SelectAllCarModels_Result> SelectAllCarModels()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllCarModels_Result>("SelectAllCarModels");
        }
    
        public virtual ObjectResult<GetAllUserOrders_Result> GetAllUserOrders(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUserOrders_Result>("GetAllUserOrders", userIDParameter);
        }
    
        public virtual ObjectResult<GetRentalsByUser_Result> GetRentalsByUser(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRentalsByUser_Result>("GetRentalsByUser", userIDParameter);
        }
    
        public virtual int sp_alterdiagram1(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram1", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram1(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram1", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram1(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram1", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition1_Result> sp_helpdiagramdefinition1(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition1_Result>("sp_helpdiagramdefinition1", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams1_Result> sp_helpdiagrams1(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams1_Result>("sp_helpdiagrams1", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram1(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram1", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams1");
        }
    }
}
