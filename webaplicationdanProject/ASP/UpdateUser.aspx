<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="webaplicationdanProject.ASP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="/Css/login_page.css">
 <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="wrapper">
     <form action="UpdateUser.aspx" runat="server" method="post">
     <h10>Update User</h10>
     <div class="input-box">
         <input type="text" id="username" name="username" placeholder="username" required />
         <i class ='bx bxs-user'></i>
     </div>
     <div class="input-box">
         <input type="password" id="password" name="password" placeholder="password" required />
         <i class ='bx bxs-lock'></i>
     </div>  
     <%--<div class="input-box">
         <input type="Email" id="email" name="email" placeholder="email" required />
         <i class ='bx bxl-gmail'></i>
     </div>  
     <div class="input-box">
         <input type="Date" id="date" name="date" placeholder="date"  />
         <i class ='bx bx-calendar'></i>
     </div>  --%>
     
     <button type="submit" class="btn"> update </button>

     <div class="register-link">
         <p>changed your mind? <a href="mainASP.aspx">home page</a></p>
     </div>
    </form>
</div>

</asp:Content>
