<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailedOrder.aspx.cs" Inherits="PaperPhil.Admin.DetailedOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="DetailedOrderTitle" runat="server" class="ContentHead">
        <h1>Full Order</h1>
    </div>
    <asp:GridView ID="CertainOrderDetail" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4" ItemType="PaperPhil.Models.OrderDetail" SelectMethod="GetOrder" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="ID" SortExpression="ProductId" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
            <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) * Convert.ToDouble(Item.UnitPrice)))%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
