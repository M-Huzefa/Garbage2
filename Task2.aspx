﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="GridView.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="StudentGridData" runat="server" BackColor="White" BorderColor="#E7E7FF"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Calibri" Font-Size="Larger"
                AllowPaging="true" PageSize="5" OnPageIndexChanging="PageIndexChanging"
                OnRowEditing="RowEditing" OnRowCancelingEdit="RowCancelingEdit"
                AutoGenerateEditButton="True" OnRowDeleting="RowDeleted"> <%--OnRowUpdating ="RowUpdating"--%>     
                <%--OnRowCancelingEdit="TaskGridView_RowCancelingEdit" >--%>
                
                <Columns>
                    <asp:CommandField HeaderText="Commands" ShowDeleteButton="true"/>
                </Columns>

                <AlternatingRowStyle BackColor="#F7F7F7" />

                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />

                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

                <SortedAscendingCellStyle BackColor="#F4F4FD" />

                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />

                <SortedDescendingCellStyle BackColor="#D8D8F0" />

                <SortedDescendingHeaderStyle BackColor="#3E3277" />
                
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
