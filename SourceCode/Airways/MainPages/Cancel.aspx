<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Cancel.aspx.cs" Inherits="Airways.Cancel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

   
    <table style ="margin-left:350px;">
        <tr>
            <td colspan="2" style="font-family:Arial"><h1>Cancel Your Ticket Here</h1> 
                <br />
            </td>
        </tr>
        <tr>
            <td style="height: 58px"><b> Enter Your Booking ID </b></td>
            <td style="height: 58px; width: 261px;"> <asp:TextBox ID="BookingID_TextBox" runat="server" Height="22px" Width="170px" MaxLength="6"></asp:TextBox> </td>
        </tr>
        <tr>
           <td style="text-align: center; height: 110px;" colspan="2"> <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" BackColor="White" Font-Bold="True" Font-Italic="False" ForeColor="Red" Height="30px" Width="100px" style="border-radius:20px;"/>
               <br />
               <br />
               <br />
               <asp:Label ID="Status_Label" runat="server" Font-Size="Larger" ForeColor="Red"></asp:Label>
               <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text=""></asp:Label>
            </td>
        </tr>
    </table>
      

</asp:Content>
