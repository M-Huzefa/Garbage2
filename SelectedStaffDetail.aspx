<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectedStaffDetail.aspx.cs" Inherits="GridView.SelectedStaffDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container1">
            <h1>The details are as under: </h1>
            <p runat="server" id="id" />
            <p runat="server" id="rollno" />
            <p runat="server" id="name" />
            <p runat="server" id="salary" />
            <p runat="server" id="address" />

        </div>
    </form>
</body>
</html>
