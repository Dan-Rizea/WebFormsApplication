<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="PaperPhil.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div id="CheckoutTitle" runat="server" class="ContentHead">
        <h1>Checkout</h1>
    </div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4" ItemType="PaperPhil.Models.CartItem" SelectMethod="GetShoppingCartItems" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="BookID" HeaderText="ID" SortExpression="BookID" />
            <asp:BoundField DataField="Product.BookTitle" HeaderText="Name" />
            <asp:BoundField DataField="Product.UnitPrice" HeaderText="Price (each)" DataFormatString="{0:c}" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>" ReadOnly="True"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) * Convert.ToDouble(Item.Product.UnitPrice)))%>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <div class="form-group">
        <label class="col-form-label" for="firstName">First Name</label>
        <asp:TextBox type="text" class="form-control" id="firstName" runat ="server" CausesValidation="True"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="col-form-label" for="lastName">Last Name</label>
        <asp:TextBox type="text" class="form-control" id="lastName" runat ="server" CausesValidation="True"></asp:TextBox>

    </div>
    <div class="form-group">
        <label for="address">Address</label>
        <asp:TextBox type="text" class="form-control" id="address" runat ="server" CausesValidation="True" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="col-form-label" for="city">City</label>
        <asp:TextBox type="text" class="form-control" id="city" runat ="server" CausesValidation="True"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="col-form-label" for="state">State</label>
        <asp:TextBox type="text" class="form-control" id="state" runat ="server" CausesValidation="True"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="col-form-label" for="state">Country</label>
        <asp:TextBox type="text" class="form-control" id="country" runat ="server" CausesValidation="True"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="col-form-label" for="postalCode">Postal Code</label>
        <asp:TextBox type="text" class="form-control" id="postalCode" runat ="server" CausesValidation="True"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="col-form-label" for="phone">Phone Number</label>
        <asp:TextBox type="text" class="form-control" id="phone" runat ="server" CausesValidation="True" TextMode="Phone"></asp:TextBox>
    </div>
    <div class="form-group">
      <label for="email">Email Address</label>
      <asp:TextBox type="text" class="form-control" id="email" runat ="server" CausesValidation="True" TextMode="Email"></asp:TextBox>
    </div>
    <table>
        <tr>
            <td>
                <asp:Button ID="PlaceOrderBtn" runat="server" Text="Place an Order" OnClick="OrderBtn_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

