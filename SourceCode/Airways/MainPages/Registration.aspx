<style type="text/css">
       
</style>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Airways.Registration" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ARS </title>
    <link href="../StyleSheets/StyleSheet.css" rel="stylesheet" />

</head>


<body style="background-image: url('/Images/Main BGI.jpg'); background-size: cover;">

    <form id="EntryMaster" runat="server">

        <table style="border: ridge; border-color: white; border-radius: 8px;">
            <tr>
                <td style="font-family: Forte; line-height: 40px; font-size: 45px; width: 1200px;">Air Ticket Reservation System             </td>
                <td style="height: 100px; width: 200px; font-family: Forte; line-height: 40px; font-size: 45px;">
                    <asp:Image ID="Image2" runat="server" Height="85px" ImageUrl="~/Images/Aeroplane.png" Style="margin-left: 100px" Width="187px" />
                </td>

            </tr>

        </table>

        <marquee behavior="scroll" direction="left" style="height: 35px; color: whitesmoke; border-radius: 8px; border: ridge; background: rgba(255,255,255,0.5); line-height: 25PX; font-size: 25PX; font-family: 'Brush Script MT';"> Staytune for more updates....!!!</marquee>




        <table style="background: rgba(255,255,255,0.6); height: 500px; width: 1335px; padding-left: 450px; border: ridge; border-radius: 8px;">
            <tr>

                <td colspan="4" style="font-family: 'Cooper Black'; font-size: 26px; padding-left: 50px;">Registration</td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="Name_TextBox" runat="server" Width="150px" placeholder="Name" Style="height: 28px; width: 150px; border-radius: 2px;" BorderColor="#999999" MaxLength="30" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name field cannot be blank." CssClass="auto-style4" ControlToValidate="UN_TextBox" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="EID_TextBox" runat="server" Width="130px" TextMode="Email" placeholder="xxxx@gmail.com" Style="height: 28px; width: 150px; border-radius: 2px;" MaxLength="30" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Email_RFV" runat="server" ErrorMessage="Email ID field cannot be blank." CssClass="auto-style4" ControlToValidate="EID_TextBox" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="UN_TextBox" runat="server" Width="150px" placeholder="Username" Style="height: 28px; width: 150px; border-radius: 2px;" BorderColor="#999999" MaxLength="30" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Name_RFV" runat="server" ErrorMessage="Username field cannot be blank." CssClass="auto-style4" ControlToValidate="UN_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="UN_TextBox" Display="Dynamic" ErrorMessage="Minimum of 5 Characters" style="color: #FF0000" ValidationExpression="[a-zA-Z0-9\s(?=.*\d)(?=.*[$@$!%*#?_&<>,./-;:{}]{5,}"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="Pass_TextBox" runat="server" Width="130px" TextMode="Password" placeholder="Password" Style="height: 28px; width: 150px; border-radius: 2px;" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Pass_RFV" runat="server" ErrorMessage="Password field cannot be blank." CssClass="auto-style4" ControlToValidate="Pass_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev1" runat="server"
                        ControlToValidate="Pass_TextBox"
                        ErrorMessage="Minimum 5 Characters atleast 1 Alphabet, 1 Number and 1 Special Character"
                        ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?_&<>,./-;:{}])[A-Za-z\d$@$!%*#?_&<>,./-;:{}]{5,}$" Display="Dynamic" ForeColor="Red" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Re -Enter Password</td>
                <td class="auto-style1">
                    <asp:TextBox ID="RPass_TextBox" runat="server" Width="130px" TextMode="Password" placeholder="Re-Password" Style="height: 28px; width: 150px; border-radius: 2px;" MaxLength="30"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Display="Dynamic" ErrorMessage="Re-Password field cannot be blank." CssClass="auto-style4" ControlToValidate="RPass_TextBox" Style="color: #FF0000"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" ErrorMessage="Passwords didn't matched." CssClass="auto-style4" ControlToCompare="Pass_TextBox" ControlToValidate="RPass_TextBox" Style="color: #FF0000"></asp:CompareValidator>
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>Date of Birth</td>
                <td>
                    <asp:TextBox ID="DOB_TextBox" runat="server" Width="130px" placeholder="DD-MM-YYYY" Style="height: 28px; width: 150px; border-radius: 2px;" MaxLength="30" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="DOB_REV" runat="server" ControlToValidate="DOB_TextBox" ErrorMessage="Please Enter The Correct Date Format" Style="color: #FF0000" ValidationExpression="^(?:[012]?[0-9]|3[01])[-](?:0?[1-9]|1[0-2])[-](?:[0-9]{2}){1,2}$"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Address_TextBox" runat="server" Width="130px" TextMode="MultiLine" placeholder="Address" Style="height: 28px; width: 150px; border-radius: 2px;"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td>
                    <asp:TextBox ID="Phone_TextBox" runat="server" Width="130px" TextMode="Phone" placeholder="10 Digit" Style="height: 28px; width: 150px; border-radius: 2px;" MaxLength="10" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Phone Number Field cannot be blank." CssClass="auto-style4" ControlToValidate="Phone_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter The Valid Phone Number" ControlToValidate="Phone_TextBox" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Gender</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="86px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>SSN Type</td>
                <td>
                    <asp:DropDownList ID="SSN_DropDownList" runat="server" Width="130px" Style="height: 28px; width: 150px; border-radius: 2px;">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Voter ID</asp:ListItem>
                        <asp:ListItem>Aadhar</asp:ListItem>
                        <asp:ListItem>Passport Number</asp:ListItem>
                        <asp:ListItem>Driving License</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Choose SSN Type" CssClass="auto-style4" ControlToValidate="SSN_DropDownList" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>SSN Number</td>
                <td>
                    <asp:TextBox ID="SSN_Type_TextBox" runat="server" Width="130px" Style="height: 28px; width: 150px; border-radius: 2px;" MaxLength="12" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="SSN field cannot be blank." CssClass="auto-style4" ControlToValidate="SSN_Type_TextBox" Style="color: #FF0000" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr style="height:45px;">
                <td colspan="4">
                    <asp:Label ID="Registration_Successful_Label" runat="server" Text="" style="color:green; line-height:45px; font-weight:bold; font-family:Arial;"></asp:Label>
                    <asp:Label ID="UserName_Label" runat="server" Text="" style="color:green; line-height:45px; font-weight:bold; font-family:Arial;"></asp:Label>
                    <asp:Label ID="Login_Label" runat="server" Text="  &lt;a href=&quot;Login.aspx&quot; style=&quot;text-align: center; text-decoration:none; height:20px; color:black; font-size:20px;&quot;&gt;Please click here to Login &lt;/a&gt;"></asp:Label>

                    <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text="" style="color: #FF0000"></asp:Label>

                </td>

            </tr>
        </table>
        <div style="text-align: center; height: 15px; font-weight: bold; color: black; border-radius: 8px; border: ridge; background: rgba(255,255,255,0.5); line-height: 15px; font-size: 15PX;">Copyright &copy; AirTicket Reservation System   </div>

    </form>

</body>
</html>

