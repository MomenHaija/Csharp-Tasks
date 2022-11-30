<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
&nbsp;&nbsp; Number1:
            <asp:TextBox ID="Number1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp; Number2:
            <asp:TextBox ID="Number2" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Add" runat="server" Text="+" OnClick="Add_Click1" />
&nbsp;&nbsp;
            <asp:Button ID="Sub" runat="server" OnClick="Sub_Click" Text="-" />
&nbsp;&nbsp;
            <asp:Button ID="Div" runat="server" OnClick="Div_Click" Text="/" />
&nbsp;
            <asp:Button ID="Mult" runat="server" OnClick="Mult_Click" Text="*" />
&nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Result" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
