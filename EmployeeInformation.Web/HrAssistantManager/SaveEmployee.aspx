<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveEmployee.aspx.cs" Inherits="EmployeeInformation.Web.HrAssistantManager.SaveEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="ImageShow" runat="server" Height="117px" Width="125px" />
    
    
    <asp:FileUpload ID="imageFileUpload" runat="server" />
    
    
    <br/>
    <asp:Button ID="uploadButton" runat="server" Text="Upload" OnClick="uploadButton_Click" />
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
    <asp:CheckBox ID="Male" runat="server" Text="Male"/>
    <asp:CheckBox ID="Female" runat="server" Text="Female"/>
    <br/>
    <asp:Label ID="Label12" runat="server" Text="Designation"></asp:Label>
    <asp:DropDownList ID="designationDropDownList" runat="server">
    </asp:DropDownList>
    <br/>
    <asp:Label ID="Label13" runat="server" Text="Date of Birth"></asp:Label>
    <asp:TextBox ID="dateOfBirthTextBox" placeholder="yyyy-mm-dd" runat="server" ></asp:TextBox>

    <br/>
    <asp:Label ID="Label14" runat="server" Text="Joining Date"></asp:Label>
    <asp:Calendar ID="joiningDateCalendar" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="200px">
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <SelectorStyle BackColor="#FFCC66" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
    </asp:Calendar>
    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
 <asp:Label ID="msgLabel" runat="server"></asp:Label>
    <br/>

</asp:Content>
