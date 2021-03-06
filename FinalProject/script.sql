USE [master]
GO
/****** Object:  Database [PeretzRents]    Script Date: 29/10/2016 18:12:52 ******/
CREATE DATABASE [PeretzRents]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PeretzRents', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PeretzRents.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PeretzRents_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PeretzRents_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PeretzRents] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PeretzRents].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PeretzRents] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PeretzRents] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PeretzRents] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PeretzRents] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PeretzRents] SET ARITHABORT OFF 
GO
ALTER DATABASE [PeretzRents] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PeretzRents] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PeretzRents] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PeretzRents] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PeretzRents] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PeretzRents] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PeretzRents] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PeretzRents] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PeretzRents] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PeretzRents] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PeretzRents] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PeretzRents] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PeretzRents] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PeretzRents] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PeretzRents] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PeretzRents] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PeretzRents] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PeretzRents] SET RECOVERY FULL 
GO
ALTER DATABASE [PeretzRents] SET  MULTI_USER 
GO
ALTER DATABASE [PeretzRents] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PeretzRents] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PeretzRents] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PeretzRents] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PeretzRents] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PeretzRents', N'ON'
GO
USE [PeretzRents]
GO
/****** Object:  Table [dbo].[CarFleet]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarFleet](
	[CarID] [nvarchar](50) NOT NULL,
	[CarModelID] [int] NOT NULL,
	[Mileage] [int] NOT NULL,
	[Photo] [nvarchar](256) NOT NULL,
	[ReadyForRental] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_CarFleet] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CarsModels]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarsModels](
	[CarModelID] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerID] [int] NOT NULL,
	[CarModel] [nvarchar](50) NOT NULL,
	[ManufactureYear] [int] NOT NULL,
	[Transmission] [nvarchar](50) NOT NULL,
	[DailyRate] [money] NOT NULL,
	[LateFee] [money] NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_CarsModels] PRIMARY KEY CLUSTERED 
(
	[CarModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manufactures]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufactures](
	[ManufacturerID] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerName] [nvarchar](50) NOT NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_Manufactures] PRIMARY KEY CLUSTERED 
(
	[ManufacturerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[CarRentalID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [nvarchar](50) NOT NULL,
	[UserID] [int] NOT NULL,
	[RentalStartDate] [date] NOT NULL,
	[RentalFinishDate] [date] NOT NULL,
	[RentalActualFinishDate] [date] NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[CarRentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[ID] [nvarchar](50) NULL,
	[EMail] [nvarchar](max) NULL,
	[DateOfBirth] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
 CONSTRAINT [PK__Users__1788CCAC638DEED8] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Users__536C85E4A99A43E7] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserVsRoles]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserVsRoles](
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_UserVsRoles] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CarFleet]  WITH CHECK ADD  CONSTRAINT [FK_CarFleet_CarsModels] FOREIGN KEY([CarModelID])
REFERENCES [dbo].[CarsModels] ([CarModelID])
GO
ALTER TABLE [dbo].[CarFleet] CHECK CONSTRAINT [FK_CarFleet_CarsModels]
GO
ALTER TABLE [dbo].[CarsModels]  WITH CHECK ADD  CONSTRAINT [FK_CarsModels_Manufactures] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[Manufactures] ([ManufacturerID])
GO
ALTER TABLE [dbo].[CarsModels] CHECK CONSTRAINT [FK_CarsModels_Manufactures]
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_CarFleet] FOREIGN KEY([CarID])
REFERENCES [dbo].[CarFleet] ([CarID])
GO
ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_CarFleet]
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_Rentals_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_Rentals_Users]
GO
ALTER TABLE [dbo].[UserVsRoles]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[UserVsRoles]  WITH CHECK ADD  CONSTRAINT [FK__UserVsRol__UserI__182C9B23] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[UserVsRoles] CHECK CONSTRAINT [FK__UserVsRol__UserI__182C9B23]
GO
/****** Object:  StoredProcedure [dbo].[AddCarModel]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[AddCarModel] @manufacturerID int , @carModel nvarchar(50)  , @manufactureYear int ,
							 @transmission nvarchar(50), @dailyRate money , @lateFee money
as 
insert into CarsModels(ManufacturerID,CarModel,ManufactureYear,Transmission,DailyRate,LateFee)
values (@manufacturerID, @carModel , @manufactureYear, @transmission, @dailyRate  , @lateFee )


GO
/****** Object:  StoredProcedure [dbo].[AddCarToCarFleet]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCarToCarFleet] @carID nvarchar (50), @carModelID int , @mileage int , @photo nvarchar(256) , @readyForRental bit
as 
insert into CarFleet(CarID,CarModelID,Mileage,Photo,ReadyForRental)
values (@carID,@carModelID , @mileage, @photo , @readyForRental)


GO
/****** Object:  StoredProcedure [dbo].[AddManufacturer]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[AddManufacturer] @manufacturerName nvarchar(50)
as 
insert into Manufactures(ManufacturerName)
values (@manufacturerName )


GO
/****** Object:  StoredProcedure [dbo].[AddRental]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddRental]  @carID nvarchar(50), @userID int,
							@rentalStartDate date,@rentalFinishDate date,
							@rentalActualDate date
as 
insert into Rentals(CarID,UserID,RentalStartDate,RentalFinishDate,RentalActualFinishDate)
values (@carID,@userID,@rentalStartDate,@rentalFinishDate,@rentalActualDate )


GO
/****** Object:  StoredProcedure [dbo].[CheckAvailability]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckAvailability] @startTime as date ,@endTime as date
as 
--select * from [dbo].[CarFleet] cf 
Select cf.Mileage , cf.Photo, mf.ManufacturerName, cm.CarModel, cm.Transmission 
from CarsModels AS cm  join CarFleet AS cf 
			on cm.CarModelID = cf.CarModelID
			join Manufactures AS mf  on
			cm.ManufacturerID = mf.ManufacturerID
where
not exists (select 1 from Rentals r1 where r1.CarID=cf.CarID and @startTime between r1.RentalStartDate and r1.RentalFinishDate
  or @endTime between r1.RentalStartDate and r1.RentalFinishDate )
and not exists (select 1 from Rentals r1 where @startTime>= r1.RentalStartDate and @endTime <= r1.RentalFinishDate)



GO
/****** Object:  StoredProcedure [dbo].[DeleteCarFormFleet]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCarFormFleet] @carID nvarchar (50)
as 
UPDATE CarFleet 
set IsDelete = 1
where CarID = @carID	


GO
/****** Object:  StoredProcedure [dbo].[DeleteCarModel]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCarModel] @carModelID int 
as 
UPDATE CarsModels 
set IsDelete = 1
where CarModelID = carModelID	


GO
/****** Object:  StoredProcedure [dbo].[DeleteManufacturer]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[DeleteManufacturer] @manufcaturerID int 
as 
UPDATE Manufactures 
set IsDelete = 1
where ManufacturerID = @manufcaturerID	


GO
/****** Object:  StoredProcedure [dbo].[SelectAllCars]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SelectAllCars] 
as 

Select cf.Mileage , cf.Photo, mf.ManufacturerName, cm.CarModel, cm.Transmission 
from CarsModels AS cm  join CarFleet AS cf 
			on cm.CarModelID = cf.CarModelID
			join Manufactures AS mf  on
			cm.ManufacturerID = mf.ManufacturerID



GO
/****** Object:  StoredProcedure [dbo].[SelectAllCarsIsNotDeleted]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SelectAllCarsIsNotDeleted]  
as 

Select cf.Mileage , cf.Photo, mf.ManufacturerName, cm.CarModel, cm.Transmission 
from CarsModels AS cm  join CarFleet AS cf 
			on cm.CarModelID = cf.CarModelID
			join Manufactures AS mf  on
			cm.ManufacturerID = mf.ManufacturerID
where  cf.IsDelete = 0 


GO
/****** Object:  StoredProcedure [dbo].[UpdateCarFeelt]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
cREATE PROCEDURE [dbo].[UpdateCarFeelt] @carID nvarchar(50), @carModelID int , @mileage int  ,@photo nvarchar (256) ,@readyForRental bit
as 
UPDATE CarFleet 
set CarModelID = @carModelID ,Mileage = @mileage  ,Photo =  @photo ,ReadyForRental = @readyForRental
where CarID = @carID	



GO
/****** Object:  StoredProcedure [dbo].[UpdateCarModel]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCarModel] @carModelID int, @manufacturerID int , @carModel nvarchar(50)  , @manufactureYear int ,
								 @transmission nvarchar(50), @dailyRate money , @lateFee money
as 
UPDATE CarsModels 
set ManufacturerID = @manufacturerID ,CarModel = @carModel  ,ManufactureYear =  @manufactureYear ,Transmission = @transmission
where CarModelID= @carModelID	



GO
/****** Object:  StoredProcedure [dbo].[UpdateManufacturer]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
cREATE PROCEDURE [dbo].[UpdateManufacturer] @manufacturerID int,@manufacturerName nvarchar(50)
as 
UPDATE Manufactures 
set ManufacturerName = @manufacturerName
where ManufacturerID = @manufacturerID	



GO
/****** Object:  StoredProcedure [dbo].[UpdateRentals]    Script Date: 29/10/2016 18:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
cREATE PROCEDURE [dbo].[UpdateRentals] @carRentalID int,@carID nvarchar(50), @userID int , @rentalStartDate date ,
							   @rentalFinishDate date , @rentelActualFinishDate date  
as 
UPDATE Rentals 
set CarID = @carID , UserID = @userID , RentalStartDate= @rentalStartDate , RentalFinishDate = @rentalFinishDate , 
	RentalActualFinishDate = @rentelActualFinishDate
where CarRentalID = @carRentalID	



GO
USE [master]
GO
ALTER DATABASE [PeretzRents] SET  READ_WRITE 
GO
