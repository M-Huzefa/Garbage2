<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="GridView.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
    <style> 
        body{
            background-color: lightyellow;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <h1>Staff list</h1>
            <asp:TextBox ID="textbox" runat="server"></asp:TextBox>
            <asp:Button ID="button" Text="Search" runat="server" OnClick="SearchResults"/>
            <asp:GridView CssClass="Grid" ID="StaffGridData" runat="server" BackColor="White" BorderColor="#E7E7FF"
                 BorderWidth="1px" CellPadding="8" Font-Names="Calibri" Font-Size="X-Large" 
                AutoGenerateColumns="false" 
                AllowPaging="true" PageSize="7" OnPageIndexChanging="PageIndexChanging"
                OnRowEditing="RowEditing" OnRowCancelingEdit="RowCancelingEdit" 
                OnRowDeleting="RowDeleted" OnRowUpdating ="RowUpdating" OnSelectedIndexChanging="onselectedindexchanging" >
                
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="ID" /> 
                    <asp:BoundField HeaderText="EmpNo" DataField="RollNo" /> 
                    <asp:BoundField HeaderText="Name" DataField="Name" /> 
                    <asp:BoundField HeaderText="Salary" DataField="Salary" /> 
                    <asp:BoundField HeaderText="Address" DataField="Address" /> 
                    <asp:CommandField HeaderText="Commands" ShowDeleteButton="true"  />
                    <asp:CommandField HeaderText="Commands" ShowEditButton ="true" />
                    <asp:CommandField HeaderText="Commands" ShowSelectButton="true"/>

                </Columns>

                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

                <AlternatingRowStyle BackColor="#F7F7F7" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

                <PagerStyle BackColor="#4A3C8C" ForeColor="#F7F7F7" Wrap="true" Font-Bold="true" HorizontalAlign="Right" />

                <SelectedRowStyle BackColor="red" Font-Bold="True" ForeColor="#F7F7F7" />
                
            </asp:GridView>
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
