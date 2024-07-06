<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="IPExample.aspx.cs" Inherits="Sessions.IPExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div style="margin-top: 50px">
            <h3>IsPostBack Example</h3>
            <asp:Button  OnClick="btnrefresh_Click"  runat="server" ID="btnrefresh" Text="Postback Request" />
            <br />
            <asp:DropDownList runat="server" Style="margin-top: 15px" ID="ddlcity">

            </asp:DropDownList>
        </div>
    </div>
</asp:Content>
