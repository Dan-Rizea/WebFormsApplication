<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="PaperPhil.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:FormView ID="productDetail" runat="server" ItemType="PaperPhil.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
    <ItemTemplate>
        <div>
            <h1><%#:Item.BookTitle %></h1>
        </div>
    <br />
    <img src="/Content/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.BookTitle %>"/>
    <table>
        <tr>
            <td style="vertical-align: top; text-align:left;">
                <b>Release Year:</b><%#:Item.BookRelease %>
                <br />
                <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                <br />
                <span><b>Product ISBN:</b>&nbsp;<%#:Item.ISBN %></span>
                <br />
            </td>
        </tr>
    </table>
    </ItemTemplate>
</asp:FormView>
<asp:FormView ID="authorDetail" runat="server" ItemType="PaperPhil.Models.Author" SelectMethod ="GetAuthor" RenderOuterTable="false">
    <ItemTemplate>
    <table>
        <tr>
            <td style="vertical-align: top; text-align:left;">
                <span><b>Author Name:</b>&nbsp;<%#:Item.AuthorName %></span>
                <br />  
                <span><b>Author Website:</b>&nbsp;<%#:Item.AuthorWebsite %></span>
                <br />
                <span><b>Author Country:</b>&nbsp;<%# Item.AuthorCountry %></span>
            </td>
        </tr>
    </table>
    </ItemTemplate>
</asp:FormView>
<asp:FormView ID="publisherDetail" runat="server" ItemType="PaperPhil.Models.Publisher" SelectMethod ="GetPublisher" RenderOuterTable="false">
    <ItemTemplate>
    <table>
        <tr>
            <td style="vertical-align: top; text-align:left;">
                <b>Publisher Name:</b><%#:Item.publisherName %>
                <br />
                <span><b>Publisher Website:</b>&nbsp;<%#: Item.publisherWebsite %></span>
                <br />
            </td>
        </tr>
    </table>
    </ItemTemplate>
</asp:FormView>

</asp:Content>
