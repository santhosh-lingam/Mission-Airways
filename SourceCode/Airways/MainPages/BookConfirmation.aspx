<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="BookConfirmation.aspx.cs" Inherits="Airways.MainPages.BookConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <script type = "text/javascript" >
            function preventBack() { window.history.forward(); }
            setTimeout("preventBack()", 0);
            window.onunload = function () { null };
        </script> 
    </header>
    <table style="width: 79%; height: 564px; margin-left:250px; ">
        <tr>
            <td style="text-align: left; " colspan="3">
                <asp:Label ID="FinalBookConfirmation_Label" runat="server"  style="text-align: center; color: #009933;" Font-Bold="True" Font-Size="X-Large" ForeColor="#66FF66"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 267px">&nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Booking ID </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="BookingID_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Customer Name &nbsp; </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="CustomerName_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Flight ID</td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="FlightID_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Airline Name </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="AirlineName_Label" runat="server" Text=""></asp:Label>
            </td> 
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Leaving From </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="LeavingFrom_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Going To </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="GoingTo_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Date of Journey </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="DateOfJourney_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Departure Time </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="DepartTime_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Booking Date </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="BookingDate_Label" runat="server" Text=""></asp:Label>
            </td>
            <td style="height: 25px"></td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">No of Passengers </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="NoofPassengers_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Fare </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="Fare_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Total Fare </td>
            <td style="text-align: left; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">
                :
                <asp:Label ID="TotalFare_Label" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; " colspan="2">
                <table style="width: 100%">
                    </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="line-height:35px; font-size:25px;font-family: 'Times New Roman', Times, serif; font-weight: bold;"> Click Here To Book Another Ticket<asp:ImageButton ID="Image1" runat="server" ImageUrl="~/Images/ClickHere.gif" Height="52px" Width="125px" PostBackUrl="~/MainPages/Search.aspx" /></td>
            
            <td></td>
            <td></td>
            
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 267px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        
    </table>
    <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text=""></asp:Label>
</asp:Content>
