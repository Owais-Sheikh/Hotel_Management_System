CREATE DATABASE Hotel;

CREATE TABLE Room
(RoomNo		INT,
 RoomType	VARCHAR(100),
 Roomsize	VARCHAR(100),
 dailyRent	INT,
 roomStatus VARCHAR(100) DEFAULT 'Available',
 CONSTRAINT room_pk PRIMARY KEY(RoomNo))

 CREATE TABLE Guest
 (Id			INT,
  Name			VARCHAR(100),
  PhoneNo		VARCHAR(100),
  Address		VARCHAR(100),
  CONSTRAINT guest_pk PRIMARY KEY (Id))

  CREATE TABLE Service
   (serviceId		INT,
    serviceType		VARCHAR(100),
	servicePrice	INT,
	CONSTRAINT serv_pk PRIMARY KEY (serviceId))

  CREATE TABLE Reservation
  (ReservationNo	INT,
   RoomNo			INT,
   C_ID				INT,
   C_Name			VARCHAR(100),
   Check_In			VARCHAR(100),
   Check_Out		VARCHAR(100),
   NoofDays			INT,
   serviceId		INT,
   CONSTRAINT reser_pk PRIMARY KEY (ReservationNo),
   CONSTRAINT reser_fk1 FOREIGN KEY (RoomNo) REFERENCES Room(RoomNo) ON UPDATE CASCADE ON DELETE CASCADE,
   CONSTRAINT reser_fk3 FOREIGN KEY (serviceId) REFERENCES Service(serviceId) ON UPDATE CASCADE ON DELETE CASCADE,
   CONSTRAINT reser_fk2 FOREIGN KEY (C_ID) REFERENCES Guest(Id) ON UPDATE CASCADE ON DELETE CASCADE)

 SELECT * FROM Guest;
 SELECT * FROM Room;
 SELECT * FROM Reservation;
 SELECT * FROM Service;
 

 CREATE PROCEDURE usp_GetColumnData (@ColumnName varchar(50),@ReservationNo varchar(50))
AS
BEGIN
    DECLARE @sql nvarchar(max)
    SET @sql = 'SELECT ' + @ColumnName + ' FROM (((Guest Inner Join Reservation ON Guest.Id = Reservation.C_ID)
    Inner Join Room ON Reservation.RoomNo = Room.RoomNo) Inner Join Service ON Reservation.serviceId = Service.serviceId)
    WHERE ReservationNo = '+ @ReservationNo ;
    EXEC sp_executesql @sql
END;

CREATE PROCEDURE showTotalBill(@ReservationNo varchar(50))
AS
BEGIN
SELECT ((dailyRent*NoofDays) + servicePrice) FROM (((Guest Inner Join Reservation ON Reservation.C_ID = Guest.Id) Inner Join Room ON Reservation.RoomNo = Room.RoomNo) Inner Join Service ON Reservation.serviceId = Service.serviceId) WHERE ReservationNo = @ReservationNo;
END;

EXEC showTotalBill 3;
EXEC usp_GetColumnData @ColumnName = 'ReservationNo',@ReservationNo = 1;

SELECT ((dailyRent*NoofDays) + servicePrice) FROM (((Guest Inner Join Reservation ON Reservation.C_ID = Guest.Id) Inner Join Room ON Reservation.RoomNo = Room.RoomNo) Inner Join Service ON Reservation.serviceId = Service.serviceId) WHERE ReservationNo = 2;



