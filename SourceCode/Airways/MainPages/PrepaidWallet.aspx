<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="PrepaidWallet.aspx.cs" Inherits="Airways.MainPages.PrepaidWallet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width: 99%; height: 303px;">
        <tr>
            <td style="font-size:30px; font-family:'Bodoni MT Black'; line-height:55px; ">&nbsp;</td>
            <td colspan="2" style="font-size:30px; font-family:'Bodoni MT Black'; line-height:55px;">Jio Money
                </td>
            <td style="font-size:30px; font-family:'Bodoni MT Black'; line-height:55px;  width: 164px;">&nbsp;</td>
            <td style="font-size:30px; font-family:'Bodoni MT Black'; line-height:55px;  width: 10px;">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 210px; font-size:25px;" rowspan="2">
                <asp:Image ID="JioMoney_Image" runat="server" Height="166px" ImageUrl="~/Images/JioMoney.jpg" Width="146px" />
            </td>
            <td style="width: 497px; font-size:25px; text-align: left; font-weight: bold;">User Name :</td>
            <td style="text-align: left">
                <asp:Label ID="Username_Label" runat="server" style=" font-size:25px;" Font-Bold="True"></asp:Label>
            </td>
            
            <td style="width: 164px">
                &nbsp;</td>
            
            <td rowspan="3" style="width: 10px">
                <asp:Image ID="Rupees_Image" runat="server" ImageUrl="~/Images/Wallet.png" Height="113px" style="margin-left: 0px" Width="117px" /> 
            </td>
            
        </tr>
        <tr>
            <td style="width: 497px; font-size:25px; text-align: left; font-weight: bold;">Balance Amount :</td>
            <td colspan="2" style="text-align: left">
                <asp:Label ID="PrepaidWallet_Label" runat="server" style="font-size:25px;" Font-Bold="True"></asp:Label>
            &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 210px; height: 23px;">
                &nbsp;</td>
            <td style="width: 497px; height: 23px;">
                &nbsp;</td>
            <td style="height: 23px"></td>
            
            <td style="height: 23px; width: 164px;">&nbsp;</td>
            
        </tr>
    </table>

    <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text=""></asp:Label>


</asp:Content>
