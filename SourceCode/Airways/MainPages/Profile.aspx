<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Airways.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <link href="../StyleSheets/PagesStyle.css" rel="stylesheet" />

        <table id="profile" style="padding-left: 250px; text-align: left; font-size: 20px;">
            <tr>
                <td colspan="2" style="text-align: center; height: 50px;"><h3>Customer&#39;s Profile</h3></td>
                <td style="text-align: center; width: 316px; height: 50px;"></td>
            </tr>
            <tr>
                <td style="width: 223px">Customer ID</td>
                <td style="width: 473px">
                    <asp:TextBox ID="Cus_ID_TextBox" runat="server" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;" MaxLength="30"></asp:TextBox>
                </td>
                <td style="width: 316px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 223px">Name</td>
                <td style="width: 473px">
                    <asp:TextBox ID="Name_TextBox" runat="server" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;" MaxLength="30" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name field cannot be blank." CssClass="auto-style4" ControlToValidate="Name_TextBox" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>

                <td style="width: 316px">&nbsp;</td>

            </tr>
            <tr>
                <td style="width: 223px">Date Of Birth</td>
                <td style="width: 473px">
                    <asp:TextBox ID="DOB_TextBox" runat="server" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;" MaxLength="10"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="DOB_REV" runat="server" ControlToValidate="DOB_TextBox" ErrorMessage="Please Enter The Correct Date Format" Style="color: #FF0000" ValidationExpression="^(?:[012]?[0-9]|3[01])[-](?:0?[1-9]|1[0-2])[-](?:[0-9]{2}){1,2}$" Display="Dynamic"></asp:RegularExpressionValidator>
                </td>

                <td style="width: 316px">
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Your DOB" CssClass="auto-style4" ControlToValidate="DOB_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>

            </tr>
            <tr>
                <td style="height: 32px; width: 223px;">EMaill</td>
                <td style="height: 32px; width: 473px;">
                    <asp:TextBox ID="Mail_TextBox" runat="server" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;" TextMode="Email" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Email_RFV" runat="server" ErrorMessage="Email ID field cannot be blank." CssClass="auto-style4" ControlToValidate="Mail_TextBox" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>

                <td style="height: 32px; width: 316px;"></td>

            </tr>
            <tr>
                <td style="width: 223px">Phone Number</td>
                <td style="width: 473px">
                    <asp:TextBox ID="Phone_TextBox" runat="server" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Phone no field cannot be blank." CssClass="auto-style4" ControlToValidate="Phone_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>

                <td style="width: 316px">&nbsp;</td>

            </tr>
            <tr>
                <td style="height: 45px; width: 223px;">Address</td>
                <td style="height: 45px; width: 473px;">
                    <asp:TextBox ID="Address_TextBox" runat="server" TextMode="MultiLine" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter the address" ControlToValidate="Address_TextBox" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>

                <td style="height: 45px; width: 316px;"></td>

            </tr>
            <tr>
                <td style="width: 223px">Gender</td>
                <td style="width: 473px">
                    <asp:TextBox ID="Gender_TextBox" runat="server" Height="30px" Width="150px" style="border-radius:10px; font-size:18px; line-height:20px;" MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Cannot be left empty" ControlToValidate="Gender_TextBox" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>

                <td style="width: 316px">&nbsp;</td>

            </tr>
            <tr>
                <td colspan="2" style="text-align: center; height: 63px;">
                    <asp:Button ID="Edit_Button" runat="server" Text="Edit" Width="75px" Style="margin-left: 52px; border-radius:20px;font-weight:bold; flex-align:center;" OnClick="Edit_Button_Click1" Height="37px" />
                    <asp:Button ID="Update_Button" runat="server" Text="Update" Style="margin-left: 52px; border-radius:20px;font-weight:bold;" OnClick="Update_Button_Click1" Height="34px" Width="83px" />
                </td>
                <td style="text-align: center; width: 316px; height: 63px;"></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; height: 42px;">
                    <asp:Label ID="RecordUpdated_Label" runat="server" Font-Bold="True"></asp:Label>
                    <asp:Label ID="NotUsed_Label" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
                <td style="text-align: center; width: 316px; height: 42px;"></td>
            </tr>
        </table>
    
</asp:Content>
