--------------------------------------/* Customer Details Table */----------------------------------------------------------------------------
create database MissionAirways

use MissionAirways

create table CustomerDetails( CustomerID int IDENTITY(111000,1) PRIMARY KEY,
						      C_Name varchar(50) not null,
                              C_User_Name Varchar(50)not null, 
                              C_Mail varchar(50) null,
                              C_Pass varchar(50) not null ,
                              C_DOB  varchar(50) null,
                              C_Address  varchar(200)null,
                              C_Phone BigInt null,
                              C_Geneder varchar(50) null,
                              C_SSNType varchar(50) not null,
                              C_SSN varchar (50) not null,
                              PrepaidWallet money);                                                           




select * from CustomerDetails









delete from CustomerDetails where CustomerID=111007







update CustomerDetails set  PrepaidWallet=10000 where C_User_Name='Santhosh'


drop table CustomerDetails

SELECT SERVERPROPERTY('COLLATION')


--------------------------------------/* LOCATION_MASTER From TABLE */---------------------------------------------------------------------------- */


create table Location_Master(ID int primary key,
                             From_city varchar(50),
                             To_city varchar(50));


insert into Location_Master values(10,'Kolkata','Kolkata'),
                                  (11,'Delhi','Delhi'),
                                  (12,'Chennai','Chennai'),
                                  (13,'Hyderabad','Hyderbad')

drop table Location_Master

select * from Location_Master;


-------------------------------------------------/* AIRLINE_MASTER  TABLE */--------------------------------------------------------------


create table Airline_Master(ID int primary key,
                            Airline_Name varchar(50));


insert into Airline_Master values(100,'AirGo'),
                                 (101,'IndiGO'),
                                 (102,'SpiceJet'),
                                 (103,'Kingfisher');


select * from Airline_Master;

drop table Airline_Master



--------------------------------------/* FLIGHT_MASTER TABLE */---------------------------------------------------------------------------- */


create table Flight_Master(Flight_ID varchar(20) primary key,
						   Airline_ID int foreign key references Airline_Master(ID),
                           Depart_Date date,
                           Depart_Time time,
                           Arrival_Time time,
						   DepartLoc_ID int foreign key references Location_Master(ID),
                           ArriveLoc_ID int foreign key references Location_Master(ID),
                           SeatAvailable int,
                           Fare bigint);


insert into Flight_Master values('A_000',100,'2017-04-26','09:20','12:45',10,11,45,6200);

insert into Flight_Master values('AIR_200',	100,	'01-03-2018',   '09:20:00',	'12:45:00',	12,	14,	40,	4500);
insert into Flight_Master values('AIR_001',	100,	'01-03-2018',	'09:20:00',	'12:45:00',	14,	12,	40,	4500);
insert into Flight_Master values('AIR_145',	100,	'01-03-2018',	'10:00:00',	'11:00:00',	12,	14,	42,	3500);
insert into Flight_Master values('AIR_148', 100,	'01-03-2018',   '10:00:00',	'11:00:00',	14,	12,	42,	3500);
insert into Flight_Master values('IND_58',	101,	'01-03-2018',   '11:00:00',	'13:00:00',	12,	14,	15,	4852);
insert into Flight_Master values('IND_59',	101,	'01-03-2018',	'11:00:00',	'13:00:00',	14,	12,	15,	4852);
insert into Flight_Master values('JET_851',	106,	'01-03-2018',	'16:00:00',	'19:00:00',	14,	12,	36,	2300);
insert into Flight_Master values('JET_852',	106,	'01-03-2018',	'16:00:00',	'19:00:00',	12,	14,	36,	2300);
insert into Flight_Master values('KING_103',103,	'01-03-2018',	'15:00:00',	'18:00:00',	12,	14,	32,	1400);
insert into Flight_Master values('KING_105',103,	'01-03-2018',	'15:00:00',	'18:00:00',	14,	12,	32,	1400);
insert into Flight_Master values('SPJ_784',	102,    '01-03-2018',	'04:00:00',	'07:00:00',	14,	12, 19,	920);
insert into Flight_Master values('SPJ_785',	102,	'01-03-2018',	'04:00:00',	'07:00:00',	12,	14,	19,	920);



select * from Flight_Master;


drop table Flight_Master



--------------------------------------/* Cancel Table */----------------------------------------------------------------------------*/

create table CancelTicket( Booking_ID  bigint  identity(500001,1) primary key,
                           Name varchar(50)) 


select * from CancelTicket;

drop table CancelTicket

use MFRP2017
go

---------------------------------------/* Book Details Table */----------------------------------------------------------------------------


create table BookDetails ( Booking_ID bigint identity(500001,1),
                           CusID bigint ,
                           CusName varchar(50),
                           Date_Of_Journey varchar(50),
						   Flight_ID varchar(50)
                           AirlineName varchar(50),
                           Source_Loc varchar(50),
                           Destination_Loc varchar(50),
                           Pass_Count varchar(50),
                           Book_Date varchar(50),
                           Depart_Time varchar(50),
                           Fare varchar(50),
                           Tot_Fare varchar(50),
                           StatusOfBooking varchar(50))
                     
                   

select * from  BookDetails

drop table BookDetails 

alter table BookDetails add  Flight_ID varchar(50);

/--------------------------------------/*    */----------------------------------------------------------------------------
