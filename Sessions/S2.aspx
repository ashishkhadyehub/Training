<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="S2.aspx.cs" Inherits="Sessions.S2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group">
    <label id="test">Name:</label>
    <asp:TextBox runat="server" Enabled="false" ID="txtName" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
    
</div> 
<div class="form-group">
    <label>Contact:</label>
    <asp:TextBox TextMode="Number" Enabled="false" runat="server" ID="txtContact" placeholder="Enter Contact" CssClass="form-control"></asp:TextBox>
    
</div>
      
   </div>
</asp:Content>
