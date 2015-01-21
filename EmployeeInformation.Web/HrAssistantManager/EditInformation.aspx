<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditInformation.aspx.cs" Inherits="EmployeeInformation.Web.HrAssistantManager.EditInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:Image ID="ImageShow" runat="server" Height="117px" Width="125px" />
    
    
   
    <br/>
     <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="firstnameTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label2" runat="server" Text="Middle Name"></asp:Label>
    <asp:TextBox ID="middleNameTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label6" runat="server" Text="Personal Contact No"></asp:Label>
    <asp:TextBox ID="personalContactNoTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label7" runat="server" Text="Home Contact No"></asp:Label>
    <asp:TextBox ID="homeContactNoTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label8" runat="server" Text="Present Address"></asp:Label>
    <asp:TextBox ID="presenttAddressTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label9" runat="server" Text="Parmanent Address"></asp:Label>
    <asp:TextBox ID="parmanentAddressTextBox" runat="server"></asp:TextBox>
    <br/>
     <asp:Label ID="Label10" runat="server" Text="Code"></asp:Label>
    <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="Label11" runat="server" Text="Gender"></asp:Label>
    <asp:TextBox ID="genderTextBox" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="Label12" runat="server" Text="Designation"></asp:Label>
   
     <asp:DropDownList ID="designationDropDownList" runat="server">
    </asp:DropDownList>
    <br/>
    <asp:Label ID="Label13" runat="server" Text="Date of Birth"></asp:Label>
    <asp:TextBox ID="dateOfBirthTextBox"  runat="server" ></asp:TextBox>

    <br/>
    <asp:Label ID="Label14" runat="server" Text="Joining Date"></asp:Label>
    <asp:TextBox ID="joiningDateTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
 <asp:Label ID="msgLabel" runat="server"></asp:Label>
    <br/>
</asp:Content>
