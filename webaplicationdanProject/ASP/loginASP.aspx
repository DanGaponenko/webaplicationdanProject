<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="loginASP.aspx.cs" Inherits="webaplicationdanProject.Html.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%--head--%>

    <link rel="stylesheet" type="text/css" href="/Css/login_page.css">
    <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--body--%>

    <div class="wrapper">
     <form action="loginASP.aspx" runat="server" method="post">
         <h10>Login</h10>
         <div class="input-box">
             <input type="text" id="username" name="username" placeholder="username" required />
             <i class='bx bxs-user'></i>
         </div>
         <div class="input-box">
             <input type="password" id="password" name="password" placeholder="password" required />
             <i class='bx bxs-lock'></i>
         </div>     
         <button type="submit" class="btn">login</button>

         <div class="register-link">
             <p>don't have an account? <a href="registerASP.aspx">register</a></p>
         </div>
     </form>
        <% =msg %>
    </div>

</asp:Content>
