<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="TripHistory.aspx.cs" Inherits="Airways.TripHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>


div.transbox {
    margin: 30px;
    background-color: #ffffff;
    border: 1px solid black;
    opacity: 0.9;
    width:940px;
    filter: alpha(opacity=60); /* For IE8 and earlier */
}

div.transbox p {
    margin: 5%;
    font-weight: bold;
    color: #000000;
}
</style>

    <h1>Booking History</h1>
        <div class="background">
  <div class="transbox">
        <asp:GridView ID="Trips_GridView" runat="server" AutoGenerateColumns="False" >
    

    
        <columns>
             <asp:BoundField DataField="Booking_ID" HeaderText="Booking ID" InsertVisible="False" ReadOnly="True" SortExpression="Booking_ID" />
            
             <asp:BoundField DataField="CusName" HeaderText="Customer Name" SortExpression="CusName" />
             <asp:BoundField DataField="Date_Of_journey" HeaderText="Date Of journey" SortExpression="Date_Of_journey" />
             <asp:BoundField DataField="AirlineName" HeaderText="Airline Name" SortExpression="AirlineName" />
             <asp:BoundField DataField="Source_Loc" HeaderText="Departure Location" SortExpression="Source_Loc" />
             <asp:BoundField DataField="Destination_Loc" HeaderText="Destination" SortExpression="Destination_Loc" />
             <asp:BoundField DataField="Book_Date" HeaderText="Book Date" SortExpression="Book_Date" HeaderStyle-Width="90px" />
             <asp:BoundField DataField="Depart_Time" HeaderText="Departure Time" SortExpression="Depart_Time" />
            <asp:BoundField DataField="Pass_Count" HeaderText="Number Of Passenger" SortExpression="Pass Count" />
             <asp:BoundField DataField="Tot_fare" HeaderText="Fare" SortExpression="Fare" />
            <asp:BoundField DataField="StatusOfBooking" HeaderText="Status" SortExpression="status" />
         </columns>

        </asp:GridView>
           </div>
            <asp:Label ID="TripsStatus_Label" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text=""></asp:Label>
            </div>  
</asp:Content>
