<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_1.aspx.cs" Inherits="RequestDemo._3_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <% Response.Write(Request.Form["txtName"]); %>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="">
    <div>
        Request对象获取表单数据<br />
        <input name="txtName" type="text" />
        <input id="Submit1" type="submit" value="提交" />
    </div>
    </form>
</body>
</html>
