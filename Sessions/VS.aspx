<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="VS.aspx.cs" Inherits="Sessions.VS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3>ViewState Example</h3>
        <asp:TextBox runat="server" ID="txtcount"></asp:TextBox>
        <asp:Button runat="server" Text="Click" ID="btnclick" OnClick="btnclick_Click" />
    </div>
</asp:Content>
