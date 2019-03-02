<%@ Page Title="" Language="C#" MasterPageFile="~/EntryMatser.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Airways.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
          <script type = "text/javascript" >
              function preventBack() { window.history.forward(); }
              setTimeout("preventBack()", 0);
              window.onunload = function () { null };
        </script> 
    </header>
    <table style="padding-left: 40px;">
        <tr style="line-height: 45px;">
            <td colspan="2">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/LogInButton.png" Style="text-align: center; font-size: 25px; color: white; line-height: 35px; height: 40px; width: 125px;" />
            </td>
            <td style="width: 62px"></td>
        </tr>
        <tr>
            <td>
                <div style="font-size: 22px; color: black; line-height: 35px;">Username</div>
                <div style="font-size: 22px; color: black; line-height: 35px;">Password</div>


            </td>
            <td style="width: 50px">


                <div>

                    <asp:TextBox ID="UserName_TextBox" CssClass="loginicon" runat="server" BorderColor="White" placeholder="Username" Style="border-radius: 6px; height: 25px;" AutoCompleteType="Disabled"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:TextBox ID="Pass_TextBox" runat="server" TextMode="Password" BorderColor="White" BorderStyle="Groove" placeholder="Password" Style="border-radius: 6px; height: 25px;" AutoCompleteType="Disabled"></asp:TextBox>
                </div>

            </td>
            <td style="width: 62px">
                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName_TextBox" ErrorMessage="Enter the username" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pass_TextBox" ErrorMessage="Enter the password" Style="color: #FF0000"></asp:RequiredFieldValidator>
                </div>

            </td>

        </tr>

        <tr>

            <td colspan="2" style="text-align: center; height: 60px">
                <br />
                <asp:Button ID="Login_button" runat="server" Text="Login" OnClick="Login_button_Click" Style="text-align: center; height: 30px; border-radius: 8px; border-color: black; width: 65px; text-align: center;" />
                <br />
                <br />
            </td>


            <td style="width: 62px">
                <br />
            </td>

        </tr>
        <tr>
            <br />
            <td colspan="2" style="padding-left: 10px;">
                <a href="ForgotPassword.aspx" style="text-align: center; text-decoration: none; color:red; font-family: 'Times New Roman'; text-align: center; font-size: 18px; line-height: 35px;">Forgot Password ?   </a> </td>
               
        </tr>
        <tr>
            <br />
            <td colspan="2" style="padding-left: 10px;">
                
                <a href="Registration.aspx" style="text-align: center; text-decoration: none; color: black; font-family: 'Times New Roman'; text-align: center; font-size: 18px; line-height: 35px;"><b>New User ? Sign up </b>  </a></td>

        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Alert_Label" runat="server"></asp:Label>

                <asp:Label ID="Exception_Label" runat="server" Font-Bold="True" Font-Size="Large" Text=""></asp:Label>

            </td>
        </tr>
    </table>
</asp:Content>
