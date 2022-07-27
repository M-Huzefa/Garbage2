<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="GridView.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet2.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <h1>Student Detail</h1>
            <asp:GridView CssClass="Grid" ID="StudentGridData" runat="server" BackColor="White" BorderColor="#E7E7FF"
                 BorderWidth="1px" CellPadding="8" Font-Names="Calibri" Font-Size="X-Large" 
                AutoGenerateColumns="false" 
                AllowPaging="true" PageSize="7" OnPageIndexChanging="PageIndexChanging"
                OnRowEditing="RowEditing" OnRowCancelingEdit="RowCancelingEdit" 
                OnRowDeleting="RowDeleted" OnRowUpdating ="RowUpdating" >
                
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="ID" /> 
                    <asp:BoundField HeaderText="RollNo" DataField="RollNo" /> 
                    <asp:BoundField HeaderText="Name" DataField="Name" /> 
                    <asp:BoundField HeaderText="Salary" DataField="Salary" /> 
                    <asp:BoundField HeaderText="Address" DataField="Address" /> 
                    <asp:CommandField HeaderText="Commands" ShowDeleteButton="true" ShowInsertButton="true" ShowHeader="true"/>
                    <asp:CommandField HeaderText="Commands" ShowEditButton ="true" ShowSelectButton="true"/>

                </Columns>

                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

                <AlternatingRowStyle BackColor="#F7F7F7" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

                <PagerStyle BackColor="#4A3C8C" ForeColor="#F7F7F7" Wrap="true" Font-Bold="true" HorizontalAlign="Right" />

                <SelectedRowStyle BackColor="red" Font-Bold="True" ForeColor="#F7F7F7" />
                
            </asp:GridView>
            <asp:Label ID="label" runat="server">ooy ooy</asp:Label>
        </div>
    </form>
</body>
</html>
