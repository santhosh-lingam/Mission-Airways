<%@ Page Title="" Language="C#" MasterPageFile="~/EntryMatser.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Airways.Logout" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="color:white;">

        <script type = "text/javascript" >
            function preventBack() { window.history.forward(); }
            setTimeout("preventBack()", 0);
             window.onunload = function () { null };
        </script> 
        
        Successfully Logged out... </h2>
    <a href="Login.aspx" style="color:white; text-decoration:none;"><br />
            <h2 style="color:aqua;">Click here to Log in</h2></a>

        
        
    
</asp:Content>
