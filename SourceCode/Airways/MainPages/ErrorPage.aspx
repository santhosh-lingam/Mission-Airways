<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Airways.MainPages.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Error 404</title>
      <script type = "text/javascript" >
          function preventBack() { window.history.forward(); }
          setTimeout("preventBack()", 0);
          window.onunload = function () { null };
        </script> 
      
</head>
<body style="background-position: 380px 19px; background-image: url('../Images/404-error.png'); background-repeat: no-repeat;">
    <form id="form1" runat="server" imageurl="~/Images/Animated Click.gif">
   
        <h1 style="text-decoration:none; font-family: Arial, Helvetica, sans-serif; font-size: 35px; margin-top:450px; margin-left:450px; height: 104px; width: 517px;">
            <a href="Login.aspx" style="text-decoration:none;"> Click Here to Login.... <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Animated Click.gif" /> </a>
        </h1>
    </form>
</body>
</html>
