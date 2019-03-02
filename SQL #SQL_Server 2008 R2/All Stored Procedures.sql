--------------------------------------/* Registration Page */----------------------------------------------------------------------------

create procedure Customer_Registration_SP @Cus_Name Varchar(50), 
									     @Cus_UName Varchar(50),
                                         @Cus_Mail varchar(50),
                                         @Cus_Pass varchar(50),
                                         @Cus_DOB  varchar(50),
                                         @Cus_Address  varchar(200),
                                         @Cus_Phone BigInt,
                                         @Cus_Geneder varchar(50),
                                         @Cus_SSNType varchar(50),
                                         @Cus_SSN varchar (50)  
as
begin 
insert into CustomerDetails(C_Name ,
                            C_User_Name,
                            C_Mail,
                            C_Pass ,
                            C_DOB ,
                            C_Address ,
                            C_Phone ,
                            C_Geneder ,
                            C_SSNType,
                            C_SSN)       values (@Cus_Name,
                                                 @Cus_UName,
                                                 @Cus_Mail,
                                                 @Cus_Pass,
                                                 @Cus_DOB,
                                                 @Cus_Address, 
                                                 @Cus_Phone, 
                                                 @Cus_Geneder, 

                                                 @Cus_SSNType, 
                                                 @Cus_SSN)
                           
update CustomerDetails set  PrepaidWallet=10000 where C_User_Name=@Cus_UName

end            
         
         
exec Customer_Registration_SP 'Santhosh','Santhosh', 'Mail', 'Password','13-12-2017', 'Adds',988878844, 'Male','Aadhar','123456789125'

drop proc Customer_Registration_SP

select * from CustomerDetails

---------------------------------------------------/* Login Page */----------------------------------------------------------------------------

create procedure LogInValidation_SP @Username varchar(50),
                                    @Password varchar (50),
                                    @Status tinyint output
as 
begin

declare @Pswd varchar(50)='';

set @Status=0;

select @Pswd =C_Pass  from CustomerDetails where C_User_Name COLLATE Latin1_General_CS_AS =@Username

    if(@Pswd COLLATE Latin1_General_CS_AS=@Password)
        set @Status=1;

end


declare @Status int =0
exec LogInValidation 'Santhosh',123, @Status out
Print @Status

drop proc LogInValidation_SP

select * from CustomerDetails



-----------------------------------------------/* Profile Page Update */----------------------------------------------------------------------------
     


create procedure CustomerProfileUpdate_SP @Cus_Name Varchar(50),
                                          @Cus_Mail varchar(50),                                                                   
                                          @Cus_DOB  varchar(50),
                                          @Cus_Address  varchar(200),
                                          @Cus_Phone BigInt,
                                          @Cus_Geneder varchar(50),
                                          @Cus_ID int,
                                          @Status int out
                                         
                             
as
begin 

update  CustomerDetails  set C_Name=@Cus_Name,
                             C_Mail=@Cus_Mail,                             
                             C_DOB=@Cus_DOB,
                             C_Address= @Cus_Address,
                             C_Phone =@Cus_Phone,
                             C_Geneder=@Cus_Geneder    where   @Cus_ID=CustomerID

select @Status = COUNT(*) from CustomerDetails where @Cus_ID=CustomerID
       
                                     
end          

exec CustomerProfileUpdate 'Santhosh','S@gmail.com','Hi','16/11/1994','CTS',8977877268,'Male',111000

drop proc CustomerProfileUpdate_SP

select * from CustomerDetails

---------------------------------------------------/* Booking Confirm Page Confirmation */----------------------------------------------------------------------------
     

create proc BookDetailsConfirm_SP @Cus_ID bigint,
                                 @Cus_Name varchar(50),
							     @Date_Of_Journey varchar(50),
							     @Flight_ID varchar(50),
                                 @AirlineName varchar(50),
							     @Source_Loc varchar(50),
							     @Destination_Loc varchar(50),
							     @Pass_Count varchar(50),
                                 @Book_Date varchar(50),
                                 @Depart_Time varchar(50),
                                 @Fare varchar(50),
                                 @Tot_Fare varchar(50),
                                 @Booking_ID bigint output
                              
                           
as
begin
insert into BookDetails  (CusID ,
                          CusName ,
	                      Date_Of_Journey,
                          AirlineName  ,
	                      Source_Loc  ,
	                      Destination_Loc,
	                      Pass_Count ,
                          Book_Date  ,
                          Depart_Time  ,
                          Fare   ,
                          Tot_Fare,
                          StatusOfBooking,
                          Flight_ID) values (  @Cus_ID ,
                                                     @Cus_Name,
							                         @Date_Of_journey ,
                                                     @AirlineName ,
							                         @Source_Loc ,
							                         @Destination_Loc ,
							                         @Pass_Count ,
                                                     @Book_Date ,
                                                     @Depart_Time ,
                                                     @Fare ,
                                                     @Tot_Fare,
                                                     'Booked',
                                                     @Flight_ID )
                              
select @Booking_ID = Booking_ID from   BookDetails where CusID=@Cus_ID    
   
update CustomerDetails set  PrepaidWallet =  PrepaidWallet - @Tot_Fare  where CustomerID=@Cus_ID
 
update Flight_Master set SeatAvailable = SeatAvailable-1 where Flight_ID = @Flight_ID
end  

drop proc BookDetailsConfirm_SP


declare @Booking_ID bigint
exec BookDeatilsConfirm 111000,'Santhosh','2017-04-11','IndiGo','Chennai','Kolkata','5','2017-04-25','10:00:25','2500','12500',@Booking_ID out
print @Booking_id
 
select * from BookDetails
 
 
---------------------------------------------------/* Cancellation Page */----------------------------------------------------------------------------


create proc CancelBook_SP  @Booking_ID bigint ,
                          @Status tinyint output,
                          @Cancel_Amount int output,
                          @Cus_ID int
                       

as
begin

declare @Check int =0 ;
select @Check=count(*) from BookDetails where CusID=@Cus_ID and
                                              Booking_ID =@Booking_ID and
                                              StatusOfBooking='Booked'

declare @Diff int=0;
select  @Diff = DATEDIFF(DAY,GETDATE(),Date_Of_Journey),
        @Cancel_Amount=Tot_Fare from BookDetails where Booking_ID=@Booking_ID and @Check=1;
        
             if(@Diff>=10 and @check=1 )
                set @Cancel_Amount=@Cancel_Amount-@Cancel_Amount*10/100;
                
			 else if (@Diff>5 and @Diff<10 and @check=1)
                set @Cancel_Amount=@Cancel_Amount-@Cancel_Amount*20/100;
                
             else if (@Diff>=1 and @Diff<=5 and @check=1)
                set @Cancel_Amount=@Cancel_Amount-@Cancel_Amount*50/100;
             


set @Status =0
declare @St1 int=0
select @St1=COUNT(*) from  BookDetails where Booking_ID =@Booking_ID and StatusOfBooking !='Cancelled'

              if(@St1=1)
                  set @Status=1
              else
                  set @Status=0 

              if(@St1=1)
                 set @status=1
              else
                 set @Cancel_Amount=0

update CustomerDetails
set  PrepaidWallet =  PrepaidWallet + @Cancel_Amount  where CustomerID=@Cus_ID 

update BookDetails
set  StatusOfBooking =  'Cancelled'  where CusID=@Cus_ID and Booking_ID=@Booking_ID

declare @Flight_ID varchar(50)

select @Flight_ID =Flight_ID from BookDetails where Booking_ID=@Booking_ID

update Flight_Master set SeatAvailable = SeatAvailable+1 where Flight_ID = @Flight_ID

end



drop proc CancelBook_SP

declare @status tinyint , @cancel_amount int 
exec CancelBook 500023 , @status  output, @cancel_amount  output, 111000 
print @status
print @cancel_amount

select * from BookDetails

---------------------------------------------------/* Main Master Page */----------------------------------------------------------------------------



create procedure CustomerDetailsFetch_SP @Cus_User_Name varchar(50),
                                        @Cus_ID bigint output,
                                        @Cus_Mail varchar(50) output,
                                        @Cus_DOB varchar(50)output,
                                        @Cus_Address varchar(50)output,
                                        @Cus_Phone varchar(50)output,
                                        @Cus_Gender varchar(50)output,
                                        @Bal_Amount money output
                           
                           
                             
as
begin 
select @Cus_ID = CustomerID ,
       @Cus_Mail =C_Mail,
       @Cus_DOB = C_DOB,
       @Cus_Address = C_Address,
       @Cus_Phone =C_Phone,
       @Cus_Gender =C_Geneder,
       @Bal_Amount = PrepaidWallet from  CustomerDetails where C_User_Name=@Cus_User_Name
                          
end  

select * from CustomerDetails
declare @cusID bigint  
exec CustomerDetailsFetch_SP 'Santhosh', @cusID output
print @cusID

drop proc CustomerDetailsFetch_SP

---------------------------------------------------/* Prepaid Wallet Page */----------------------------------------------------------------------------


create proc PrepaidBal_SP @Name varchar(50),
                          @Balance money output

as
begin
select    @Balance=PrepaidWallet from CustomerDetails where C_User_Name=@name
end


drop proc PrepaidBal


declare @bal money
exec PrepaidBal 'Santhosh', @bal out
print @bal

---------------------------------------------------/*Search Page SP  SEARCH_FLIGHT STORED PROCEDURE */----------------------------------------------------------------------------

CREATE procedure Search_Flight_SP    @Leaving_From varchar(50),
							        @Going_To varchar(50),
								    @Departure_Date date,
								    @Departure_Time time,
								    @Seat int
as
begin

select f.Flight_ID,
       a.Airline_Name,
       l1.From_City,
       f.Depart_Time,
       l2.To_City,
       f.Arrival_Time,
       f.Fare            from Flight_Master f 
						      join Airline_Master a on f.Airline_id=a.id 
						      join Location_Master l1 on l1.id= f.DepartLoc_id
				              join Location_Master l2 on l2.id=f.ArriveLoc_id 
    
                                                                             where l1.From_City = @Leaving_From and 
                                                                                   l2.To_City = @Going_To and 
                                                                                   f.Depart_Date = @Departure_Date and
                                                                                   f.Depart_time >= @Departure_Time and 
                                                                                   f.SeatAvailable >= @Seat            order by  f.Depart_Time

end


drop proc Search_Flight_SP

exec Search_Flight_SP 'Visakhapatnam','Chennai','2018-01-01','00:20',1;

select * from Flight_Master;

delete from Flight_Master where Flight_ID ='A_000'
---------------------------------------/* Change Password */--------------------------------------------------------------------------------------------




create procedure CustomerPasswordUpdate_SP @C_Old_Pass Varchar(50),
                                          @C_New_Passs varchar(50),
                                          @Cus_ID varchar(50),
                                          @Status int output
                             
as
begin 
declare @Check int = 0;

update  CustomerDetails   set C_Pass=@C_New_Passs  where @Cus_ID=CustomerID and 
                                                         @C_Old_Pass COLLATE Latin1_General_CS_AS =C_Pass;


select @Check=COUNT(*) from  CustomerDetails where C_Pass COLLATE Latin1_General_CS_AS  =@C_New_Passs

        if(@Check=1)
          set @Status=1
        else
          set @Status=0
end          


select * from CustomerDetails

declare @st int =0;
exec CustomerPasswordUpdate  'Hello', 'Hi', '111000', @st out
print @st

drop proc CustomerPasswordUpdate_SP


--------------------------------------------------------/* Trips Page */-------------------------------------------------------------------

create proc BookingHistory_SP @CusID varchar(50)                           
                           
as
begin
select Booking_ID,      
	   CusName ,
	   Date_Of_journey ,
       AirlineName  ,
	   Source_Loc  ,
	   Destination_Loc,
	   Pass_Count ,
       Book_Date  ,
       Depart_Time  ,      
       Tot_fare,
       StatusOfBooking from BookDetails where CusID=@CusID order by Book_Date desc
                              
 
end  

select * from BookDetails

drop proc BookingHistory_SP

----------------------------------------/* Forgot Password */ --------------------------------------------------------------------


create proc ForgotPassword_SP @SSN_Type varchar(50),
                              @SS_Number varchar(50),
                              @Confirm_Pass varchar(50),
                              @Status int out
as
begin

declare @St int =0
update CustomerDetails 

set C_Pass = @Confirm_Pass where C_SSNType =@SSN_Type and C_SSN = @SS_Number 

select @St=COUNT(*) from CustomerDetails where  C_SSNType =@SSN_Type and C_SSN = @SS_Number 

if(@St!=0)
  set @Status =1
else
  set @Status =0

end

                              