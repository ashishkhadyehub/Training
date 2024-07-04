<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Sessions.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-4">
    <div class="form-group">
        <label id="test">Name:</label>
        <asp:TextBox runat="server" ID="txtName" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
        
    </div> 
    <div class="form-group">
        <label>Contact:</label>
        <asp:TextBox TextMode="Number" runat="server" ID="txtContact" placeholder="Enter Contact" CssClass="form-control"></asp:TextBox>
        
    </div>
   <div class="form-group">
        <label>Email:</label>
        <asp:TextBox TextMode="Email" runat="server" ID="txtEmail" placeholder="Enter Email" CssClass="form-control"></asp:TextBox>
        
    </div>
   <div class="form-group">
        <label>Select City:</label>
      
        <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCities">
            <asp:ListItem Text="Select City" Value="Select"></asp:ListItem>
            <asp:ListItem Text="kolhapur" Value="kolhapur"></asp:ListItem>
            <asp:ListItem Text="Pune" Value="Pune"></asp:ListItem>
            <asp:ListItem Text="Mumbai" Value="Mumbai"></asp:ListItem>
        </asp:DropDownList>
        
    </div>
   <asp:Button runat="server"  ID="btnSubmit" Text="Submit" CssClass="btn btn-primary" />


    
</div>
</asp:Content>
