<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="amp_access.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label id="lblUserID" runat="server" Text="ID" /><br/>
        <asp:TextBox id="txtUserID" runat="server" Text="test"  /><hr/>
        <asp:Label id="Label1" runat="server" Text="Password" /><br/>
        <asp:TextBox id="txtPassword" runat="server" Text="test" TextMode="Password" /><hr/>
        <asp:Button ID="btnSend" runat="server" Text="Login" OnClick="btnSend_Click" />
    </div>
    </form>
</body>
</html>