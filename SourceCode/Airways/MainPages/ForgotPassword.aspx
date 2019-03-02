<%@ Page Title="" Language="C#" MasterPageFile="~/EntryMatser.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Airways.MainPages.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
                <table style="height: 472px; width: 450px; margin-left: 12px; padding-top: 50px;">
                    <tr>
                        <td colspan="3" style="font-family:Arial;font-size:medium;">
                            <b>Reset Password</b>
                        </td>
                    </tr>
                    <tr>
                <td style="text-align: right">SSN Type</td>
                <td>
                    <asp:DropDownList ID="SSN_DropDownList" runat="server" Width="150px" Style="height: 28px; width: 150px; border-radius: 8px;">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Voter ID</asp:ListItem>
                        <asp:ListItem>Aadhar</asp:ListItem>
                        <asp:ListItem>Passport Number</asp:ListItem>
                        <asp:ListItem>Driving License</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width: 201px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Choose SSN Type" CssClass="auto-style4" ControlToValidate="SSN_DropDownList" Style="color: #FF0000"></asp:RequiredFieldValidator>
                        </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">SSN Number</td>
                <td>
                    <asp:TextBox ID="SSN_Type_TextBox" runat="server" Width="150px" Style="height: 20px; width: 150px; border-radius: 8px;" MaxLength="12" BorderColor="#99CC00" BorderStyle="Inset"></asp:TextBox>
                </td>
                <td style="width: 201px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="SSN field cannot be blank." CssClass="auto-style4" ControlToValidate="SSN_Type_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
                    <tr>
                        <td style="text-align: right; width: 226px;">New Password </td>
                        <td style="width: 178px">
                            <asp:TextBox ID="NewPass_TextBox" runat="server" Tex tMode="Password" BorderColor="#99CC00" style="border-radius:8px; line-height:20px;" BorderStyle="Inset" Width="150px" TextMode="Password" MaxLength="15"></asp:TextBox>
                        </td>
                        <td style="width: 201px">
                            <asp:RequiredFieldValidator ID="RFV_NewPass" runat="server" ControlToValidate="NewPass_TextBox" ErrorMessage="Enter The New Password" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="rev1" runat="server"
                                ControlToValidate="NewPass_TextBox"
                                ErrorMessage="Minimum 5 characters atleast 1 Alphabet, 1 Number and 1 Special Character"
                                ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?_&<>,./-;:{}])[A-Za-z\d$@$!%*#?_&<>,./-;:{}]{5,}$" Display="Dynamic" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right; width: 226px;">Confirm Password </td>
                        <td style="width: 178px">
                            <asp:TextBox ID="ConfirmPass_TextBox" runat="server" TextMode="Password" BorderColor="#99CC00" style="border-radius:8px; line-height:20px;" BorderStyle="Inset" Width="150px" MaxLength="15"></asp:TextBox>
                        </td>
                        <td style="width: 201px">
                            <asp:RequiredFieldValidator ID="RFV_ConfirmPass" runat="server" ControlToValidate="ConfirmPass_TextBox" ErrorMessage="Enter The Confirm Password" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="NewPass_TextBox" ControlToValidate="ConfirmPass_TextBox" Display="Dynamic" ErrorMessage="Please Enter The Correct Password" Style="color: #FF0000"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 226px">&nbsp;</td>
                        <td style="width: 178px">
                            <asp:Button ID="ChangePass_Button" runat="server" Text="Change" OnClick="ChangePass_Button_Click" />
                        </td>
                        <td style="width: 201px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="ChangePass_Label" runat="server" Text="" style="color: #FF0000"></asp:Label>
                        &nbsp;
                            <a href="Login.aspx" style="text-decoration:none;"><asp:Label ID="LogIn_Label" runat="server" Text="" style="text-decoration:none;">Login Here</asp:Label></a>
                        </td>
                    </tr>
                </table>
           



</asp:Content>
