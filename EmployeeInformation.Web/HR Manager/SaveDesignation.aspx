<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveDesignation.aspx.cs" Inherits="EmployeeInformation.Web.SaveDesignation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            
        <td>
    <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
            </td>
            <td>
    <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td>
    <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
                </td>
            <td>
    <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td>
    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
            <td>
    <asp:Label ID="msgLabel" runat="server" ></asp:Label>
                </td>
        </tr>
        </table>
</asp:Content>
