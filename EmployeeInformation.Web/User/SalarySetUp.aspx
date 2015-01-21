<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalarySetUp.aspx.cs" Inherits="EmployeeInformation.Web.User.SalarySetUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Employee Code"></asp:Label>
    <asp:DropDownList ID="employeeCodeDropDownList" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="employeeCodeDropDownList_SelectedIndexChanged">
    </asp:DropDownList>
    <br/>
    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox><br/>
     <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox><br/>
     <asp:Label ID="Label4" runat="server" Text="Basic Amount"></asp:Label>
    <asp:TextBox ID="basicAmountTextBox" runat="server"></asp:TextBox><br/>
     <asp:Label ID="Label5" runat="server" Text="Medical"></asp:Label>
    <asp:TextBox ID="medicalPercentageTextBox" runat="server"></asp:TextBox>
    <asp:Label ID="Label8" runat="server" Text="% of Basic"></asp:Label> <br/>
     <asp:Label ID="Label6" runat="server" Text="Conveyance"></asp:Label>
    <asp:TextBox ID="conveyancePercentageTextBox" runat="server"></asp:TextBox>
    <asp:Label ID="Label7" runat="server" Text="% of Basic"></asp:Label><br/>
    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
    <asp:Label ID="msgLabel" runat="server" ></asp:Label>
</asp:Content>
