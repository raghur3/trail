d<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterEmp.aspx.cs" Inherits="Reval.RegisterEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .required{
            color:red;
        }
    </style>
    <title>Employee Registration</title>
    
</head>
    
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100">
        <tr>
            <th>Employee Name:<a class="required">*</a></th>
            <td><asp:TextBox ID="txtEmployeeName" runat="server" placeholder="Employee Name"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Designation:</th>
            <td><asp:DropDownList ID="DDLDesignation" runat="server">
                <asp:ListItem Value="Select">Select</asp:ListItem>
                <asp:ListItem Value="CEO">CEO</asp:ListItem>
                <asp:ListItem Value="MD">MD</asp:ListItem>
                <asp:ListItem Value="Chairman">Chairman</asp:ListItem>
                <asp:ListItem Value="Developer">Developer</asp:ListItem>
                <asp:ListItem Value="Tester">Tester</asp:ListItem>
                <asp:ListItem Value="Network Engineer">Network Engineer</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <th>Salary:<a class="required">*</a></th>
            <td><asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Email:<a class="required">*</a></th>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Mobile:<a class="required">*</a></th>
            <td><asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Qualification:</th>
            <td><asp:DropDownList ID="DDLQualification" runat="server">
                <asp:ListItem Value="Select">Select</asp:ListItem>
                <asp:ListItem Value="B.E/B.tech">B.E/B.tech</asp:ListItem>
                <asp:ListItem Value="M.tech">M.tech</asp:ListItem>
                <asp:ListItem Value="MBA">MBA</asp:ListItem>
                <asp:ListItem Value="Other">Other</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <th>Manager:</th>
            <td><asp:TextBox ID="txtManager" runat="server"></asp:TextBox></td>
        </tr>

    </table>
        <br /><br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
    </div>
    </form>
</body>
</html>
