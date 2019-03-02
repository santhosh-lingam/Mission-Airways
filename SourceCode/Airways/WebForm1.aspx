<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Airways.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">    
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
      $(function () {
          $("#datepicker").datepicker({
              dateFormat: 'dd-mm-yy',
              changeMonth: true,
              changeYear: true,
              minDate: "0D",
              
          });
      });
  </script>
</head>
<body>
 
<p>Date: <input type="text" id="datepicker"></p>
 
 
</body>
</html>
