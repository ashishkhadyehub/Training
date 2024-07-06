<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Q1.aspx.cs" Inherits="Sessions.Q1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group">
    <label id="test">Name:</label>
    <asp:TextBox runat="server" ID="txtName" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
    
</div> 
<div class="form-group">
    <label>Contact:</label>
    <asp:TextBox TextMode="Number" runat="server" ID="txtContact" placeholder="Enter Contact" CssClass="form-control"></asp:TextBox>
    
</div>
       <asp:Button runat="server" OnClick="btnConfirm_Click" CssClass="btn btn-success" ID="btnConfirm" Text="Confirm Details" />
   </div>
</asp:Content>
