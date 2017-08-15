<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <table id="CompanyDetail" style="width: 100%; height: 191px;">
    <tr>
        <td class="auto-style2">Company Details</td>
    </tr>

    <tr id =" EmployerName">
        <td class="auto-style2">Employer Name</td>
        <td class="auto-style1">
            <asp:TextBox ID="EmployerNameTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>
         
    <tr id="EmployerContactNumber">
        <td class="auto-style2">Contact Number</td>
        <td class="auto-style1">
            <asp:TextBox ID="EmployerContactNumberTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr id="EmployerLocation">
        <td class="auto-style2">Location</td>
        <td class="auto-style1">
            <asp:TextBox ID="EmployerLocationTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr id="EmployerWebsite">
        <td class="auto-style2">Website</td>
        <td class="auto-style1">
            <asp:TextBox ID="EmployerWebsiteTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr id="EmployeeId">
        <td class="auto-style2">Employee Id</td>
        <td class="auto-style1">
            <asp:TextBox ID="EmployeeIdTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="auto-style2">
            <asp:Button ID="CompanySaveButton" runat="server" Text="Save" Height="28px" OnClick="CompanySaveButton_Click" Width="71px" />
        </td>
        <td class="auto-style1">
            <asp:Button ID="CompanyEditButton" runat="server" Text="Edit" Height="26px" Width="69px" />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:PioneerConsultancyDatabaseConnectionString %>" SelectCommand="SELECT [EmployeeID] FROM [CompanyDetail]"></asp:SqlDataSource>
        </td>
        <td>
            <asp:Button ID="CompanyClearButton" runat="server" Text="Clear" Height="28px" OnClick="CompanyClearButton_Click" Width="67px" CssClass="auto-style9" />
        </td>
    </tr>
</table>

</asp:Content>