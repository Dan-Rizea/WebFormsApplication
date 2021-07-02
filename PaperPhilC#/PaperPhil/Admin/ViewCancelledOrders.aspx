<%@ Page Title="Cancelled Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCancelledOrders.aspx.cs" Inherits="PaperPhil.ViewCancelledOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
                <h3><a href ="ViewOrders.aspx">View Pending Orders</a></h3>
                <h3><a href ="ViewCompletedOrders.aspx">View Completed Orders</a></h3>
            </hgroup>
            <asp:ListView ID="CancelledOrderList" runat="server" DataKeyNames="OrderId" GroupItemCount="2" ItemType="PaperPhil.Models.Order" SelectMethod="GetUser">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td/>
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                 </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server">
                    <table>
                        <tr>
                            <td>
                                <p>Order ID: <%#:Item.OrderId %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>First Name: <%#:Item.FirstName %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Last Name: <%#:Item.LastName %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Email: <%#:Item.Email %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Address: <%#:Item.Address %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Phone Number: <%#:Item.Phone %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Postal Code: <%#:Item.PostalCode %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Country: <%#:Item.Country %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>State: <%#:Item.State %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>City: <%#:Item.City %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Order Date: <%#:Item.OrderDate %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>Total: <%#:Item.Total %></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <a href="DetailedOrder.aspx?OrderId=<%#:Item.OrderId %>">View Order</a>
                            </td>
                        </tr>
                  </table>  
              <br />
              <br />
              </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table style="width:100%;">
                    <tbody>
                        <tr>
                            <td>
                                <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                    <tr id="groupPlaceholder"></tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr>
                        </tr>
                    </tbody>
                 </table>
            </LayoutTemplate>
        </asp:ListView>
        <asp:DropDownList ID="DropDownComplete" runat="server" Type="PaperPhil.Models.Order"  SelectMethod="GetUser" AppendDataBoundItems="true" DataTextField="Email" DataValueField="OrderId">  </asp:DropDownList>
        <asp:Button ID="CompleteBtn" runat ="server" Text="Complete Order" OnClick = "CompleteOrderBtn_Click"/>
         <asp:Label ID="LabelComplete" runat="server"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownReset" runat="server" Type="PaperPhil.Models.Order" SelectMethod="GetUser" AppendDataBoundItems="true" DataTextField="Email" DataValueField="OrderId"> </asp:DropDownList>
        <asp:Button ID="ResetBtn" runat ="server" Text="ResetOrder" OnClick ="ResetOrderBtn_Click"/>
        <asp:Label ID="LabelReset" runat="server"></asp:Label>
    </div>
</section>
</asp:Content>
