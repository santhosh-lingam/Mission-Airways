<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Airways.MainPages.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 687px; height: 459px; margin-left:220px;">
        <tr>
            <td>
                <table style="height: 385px; width: 556px; margin-left: 100px; padding-top: 50px;">
                    <tr>
                        <td colspan="3" style="text-align: center; height: 60px; font-family: 'times New Roman', Times, serif; font-size: 26px; font-weight: bold;">Change Password</td>
                    </tr>
                    <tr>
                        <td style="width: 291px">&nbsp;</td>
                        <td style="width: 178px">&nbsp;</td>
                        <td style="width: 173px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 291px; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Enter Old Password :</td>
                        <td style="width: 178px">
                            <asp:TextBox ID="OldPass_TextBox" runat="server" TextMode="Password" Height="25px" Width="150px" style="border-radius:20px;"></asp:TextBox>
                        </td>
                        <td style="width: 173px">
                            <asp:RequiredFieldValidator ID="RFV_OldPass" runat="server" ControlToValidate="OldPass_TextBox" ErrorMessage="Enter The Old Password" Style="color: #FF0000"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 291px; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Enter New Password :</td>
                        <td style="width: 178px">
                            <asp:TextBox ID="NewPass_TextBox" runat="server" TextMode="Password" style="border-radius:20px;" Height="25px" Width="150px"></asp:TextBox>
                        </td>
                        <td style="width: 173px">
                            <asp:RequiredFieldValidator ID="RFV_NewPass" runat="server" ControlToValidate="NewPass_TextBox" ErrorMessage="Enter The New Password" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="rev1" runat="server"
                                ControlToValidate="NewPass_TextBox"
                                ErrorMessage="Minimum 5 characters atleast 1 Alphabet, 1 Number and 1 Special Character"
                                ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?_&<>,./-;:{}])[A-Za-z\d$@$!%*#?_&<>,./-;:{}]{5,}$" Display="Dynamic" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 291px; font-family: 'times New Roman', Times, serif; font-size: 18px; font-weight: bold;">Confirm New Password :</td>
                        <td style="width: 178px">
                            <asp:TextBox ID="ConfirmPass_TextBox" style="border-radius:20px;" runat="server" TextMode="Password" Height="25px" Width="150px"></asp:TextBox>
                        </td>
                        <td style="width: 173px">
                            <asp:RequiredFieldValidator ID="RFV_ConfirmPass" runat="server" ControlToValidate="ConfirmPass_TextBox" ErrorMessage="Enter The Confirm Password" Style="color: #FF0000"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="NewPass_TextBox" ControlToValidate="ConfirmPass_TextBox" Display="Dynamic" ErrorMessage="Please Enter The Correct Password" Style="color: #FF0000"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 59px;" colspan="2">
                            <asp:Button ID="ChangePass_Button" runat="server" Text="Change" OnClick="ChangePass_Button_Click" Font-Bold="True" Font-Size="Medium" Height="35px" Width="94px" />
                        </td>
                        <td style="width: 173px; height: 59px;"></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="ChangePass_Label" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                        </td>
                        <td style="width: 173px">&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>

    </table>

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
