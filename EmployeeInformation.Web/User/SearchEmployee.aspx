<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchEmployee.aspx.cs" Inherits="EmployeeInformation.Web.User.SearchEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
    <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="searchByCodeButton" runat="server" Text="Search By Code" OnClick="searchByCodeButton_Click" />
   
    <br/>
     <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="searchByNameButton" runat="server" OnClick="searchByNameButton_Click" Text="Search By Name" Height="25px" Width="154px" /><br/>
     <asp:Button ID="salarySetupButton" runat="server" OnClick="salarySetupButton_Click" Text="Salary Setup" />
        <asp:Button ID="SalarySheetButton" runat="server" Text="Salary Sheet" OnClick="SalarySheetButton_Click" />
        <asp:GridView ID="searchGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" >
        <Columns>
          
            <asp:TemplateField HeaderText="Code">
                <ItemTemplate>
                    
                    <asp:TextBox ID="CodeTextBox" runat="server" Text='<%# Eval("Code") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Image">
                   <ItemTemplate>
                <asp:Image ID="ImageShow" runat="server" Height="68px" Width="72px" ImageUrl='<%# Eval("ImageSource") %>' />
                    </ItemTemplate>
             </asp:TemplateField>
            <asp:TemplateField HeaderText="FirstName">
                 <ItemTemplate>
                 
                    <asp:TextBox ID="firstNameTextBox" runat="server" Text='<%# Eval("FirstName") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MiddleName">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="middleNameTextBox" runat="server" Text='<%# Eval("MiddleName") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LastName">
                 <ItemTemplate>
                    
                    <asp:TextBox ID="lastNameTextBox" runat="server" Text='<%# Eval("LastName") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Eval("Email") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PersonalContactNo">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="personalContactNoTextBox" runat="server" Text='<%# Eval("PersonalContactNo") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HomeContactNo">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="homeContactNoTextBox" runat="server" Text='<%# Eval("HomeContactNo") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PresentAddress">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="presentAddressTextBox" runat="server" Text='<%# Eval("PresentAddress") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PermanentAddress">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="permanentAddressTextBox" runat="server" Text='<%# Eval("ParmanentAddress") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Gender">
                 <ItemTemplate>
                    
                    <asp:TextBox ID="genderTextBox" runat="server" Text='<%# Eval("Gender") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DateOfBirth">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="dateOfBirthTextBox" runat="server" Text='<%# Eval("DateOfBirth") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="JoiningDate">
                 <ItemTemplate>
                    
                    <asp:TextBox ID="joiningDateTextBox" runat="server" Text='<%# Eval("JoiningDate") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DesignationId">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="DesignationIdTextBox" runat="server" Text='<%# Eval("DesignationId") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DesignationCode">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="DesignationCodeTextBox" runat="server" Text='<%# Eval("DesignationCode") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DesignationTitle">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="DesignationTextBox" runat="server" Text='<%# Eval("Designation") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
             <asp:TemplateField HeaderText="ImageSource">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="ImageSource" runat="server" Text='<%# Eval("ImageSource") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
