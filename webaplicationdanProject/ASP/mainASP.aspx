 <%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="mainASP.aspx.cs" Inherits="webaplicationdanProject.Html.mainasp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="/Css/main_page.css">
    <script src="https://kit.fontawesome.com/yourcode.js" crossorigin="anonymous"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <h1>my site</h1>


        <%--<p1 class="bn54">links:</p1>

        <br />

        <div class="bn5">
            <p2><a href="page1ASP.aspx"> link to page 1 </a> </p2>
        </div>

        <br />

        <div class="bn5">
            <p3><a href="Page2ASP.aspx"> link to page 2 </a> </p3>
        </div>

        <br />

        <div class="bn5">
            <p4><a href="Page3ASP.aspx"> link to page 3 </a> </p4>
        </div>--%>

    <div class="menu">

            <div class="bn5">
            <p2><a href="page1ASP.aspx"> link to page 1 </a> </p2>
            </div>

            <div class="bn5">
            <p3><a href="Page2ASP.aspx"> link to page 2 </a> </p3>
            </div>

            <div class="bn5">
            <p4><a href="Page3ASP.aspx"> link to page 3 </a> </p4>
            </div>
    
    </div>

</asp:Content>
