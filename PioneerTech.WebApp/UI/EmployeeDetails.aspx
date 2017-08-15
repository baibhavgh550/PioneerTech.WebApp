<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.WebApp.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style9 {
            width: 107px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        .auto-style11 {
            width: 111px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table class="tableStyle" >
        <tr>
            <td class="auto-style3" colspan="2"><h2>Employee Details</h2></td>
        </tr>
        <tr>
            <td class="auto-style7">First Name</td>
            <td class="auto-style8">
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Last Name</td>
            <td class="auto-style5">
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Email Id</td>
            <td class="auto-style5">
                <asp:TextBox ID="EmailIdTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Mobile Number</td>
            <td class="auto-style5">
                <asp:TextBox ID="MobileNumberTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Alternate Mobile Number</td>
            <td class="auto-style5">
                <asp:TextBox ID="AlternateMobileNumberTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Address</td>
            <td class="auto-style5">
                <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Alternate Address</td>
            <td class="auto-style5">
                <asp:TextBox ID="AlternateAddressTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Home Country</td>
            <td class="auto-style5">
                <asp:TextBox ID="HomeCountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Current Country</td>
            <td class="auto-style5">
                <asp:TextBox ID="CurrentCountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Zip Code</td>
            <td class="auto-style5">
                <asp:TextBox ID="ZipCodeTextBox0" runat="server"></asp:TextBox>
                </td>
        </tr>
    </table>
    

    <table style="width:100%;">
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" Width="83px" />
            </td>
            <td class="auto-style11">
                <asp:Button ID="EditButton" runat="server" CssClass="auto-style10" Text="Edit" Width="83px" />
            </td>
            <td>
                <asp:Button ID="ButtonClear" runat="server" Text="Clear" Width="84px" />
            </td>
        </tr>
    </table>
    

</asp:Content>
