<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveDesignation.aspx.cs" Inherits="EmployeeInformationSystem.HR_Manager.SaveDesignation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
