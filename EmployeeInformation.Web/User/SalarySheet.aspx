<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalarySheet.aspx.cs" Inherits="EmployeeInformation.Web.User.SalarySheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:GridView ID="salaryGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" >
        <Columns>
          
            <asp:TemplateField HeaderText="Code">
                <ItemTemplate>
                    
                    <asp:TextBox ID="CodeTextBox" runat="server" Text='<%# Eval("Code") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="FullName">
                 <ItemTemplate>
                 
                    <asp:TextBox ID="fullNameTextBox" runat="server" Text='<%# Eval("FullName") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
         
          
            <asp:TemplateField HeaderText="Email">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Eval("Email") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Basic Amount">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="basicAmountTextBox" runat="server" Text='<%# Eval("BasicAmount") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Medical Amount">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="medicalAmountTextBox" runat="server" Text='<%# Eval("MedicalAmount") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ConveyanceAmount">
                 <ItemTemplate>
                  
                    <asp:TextBox ID="conveyanceAmountTextBox" runat="server" Text='<%# Eval("ConveyanceAmount") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TotalAmount">
                 <ItemTemplate>
                   
                    <asp:TextBox ID="totalAmountTextBox" runat="server" Text='<%# Eval("TotalAmount") %>'></asp:TextBox>
                </ItemTemplate> 
            </asp:TemplateField>
           
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Grand Total"></asp:Label>
    <asp:TextBox ID="grandtotalTextBox" runat="server"></asp:TextBox>
</asp:Content>
