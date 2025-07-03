<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="searchASP.aspx.cs" Inherits="webaplicationdanProject.ASP.searchASP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
 <form action="searchASP.aspx" runat="server" method="post">
     <h3>search</h3>
     <div class="input-box">
         <input type="text" id="month" name="month" placeholder="month" required />
         <i class='bx bxs-user'></i>
     </div>
     <button type="submit" class="btn">search</button>

     <div class="register-link">
         <p>don't have an account? <a href="registerASP.aspx">register</a></p>
     </div>
 </form>
    <% =msg %>
</div>
</asp:Content>
