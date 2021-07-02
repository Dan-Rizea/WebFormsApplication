<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs"
    Inherits="PaperPhil.Admin.AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Administration</h1>
    <hr />
    <h3>Add Product:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelAddCategory" runat="server">Category:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddCategory" runat="server" ItemType="PaperPhil.Models.Category" SelectMethod="GetCategories" DataTextField="CategoryName" DataValueField="CategoryID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <tr>
            <td>
                <asp:Label ID="LabelAddAuthor" runat="server">Author:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddAuthor" runat="server" ItemType="PaperPhil.Models.Author" SelectMethod="GetAuthors" DataTextField="AuthorName" DataValueField="AuthorID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <tr>
            <td>
                <asp:Label ID="LabelAddPublisher" runat="server">Publisher:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownAddPublisher" runat="server" ItemType="PaperPhil.Models.Publisher" SelectMethod="GetPublishers" DataTextField="PublisherName" DataValueField="PublisherID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddName"
                    runat="server">Product Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Product name required." ControlToValidate="AddProductName" SetFocusOnError="true"  Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddRelease"
                    runat="server">Release:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductRelease"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                    runat="server" Text="* Relase year required."
                    ControlToValidate="AddProductRelease" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddPrice"
                    runat="server">Price:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                    runat="server" Text="* Price required." ControlToValidate="AddProductPrice"
                    SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $."
                    ControlToValidate="AddProductPrice" SetFocusOnError="True"
                    Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddISBN" runat="server">ISBN:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddProductISBN"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                    runat="server" Text="* ISBN required."
                    ControlToValidate="AddProductRelease" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="ProductImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                    runat="server" Text="* Image path required." ControlToValidate="ProductImage"
                    SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddProductButton" runat="server" Text="Add Product" OnClick="AddProductButton_Click" CausesValidation="true" />
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Add Author:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelAddAuthorName" runat="server">Author Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddAuthorName"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6"
                    runat="server" Text="* Author name required."
                    ControlToValidate="AddAuthorName" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddAuthorWebsite" runat="server">Author Website:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddAuthorWebsite"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7"
                    runat="server" Text="* Website required."
                    ControlToValidate= "AddAuthorCountry" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddAuthorCountry" runat="server">Author Country:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddAuthorCountry"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8"
                    runat="server" Text="* Country required."
                    ControlToValidate="AddAuthorCountry" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
        <asp:Button ID="AddAuthorButton" runat="server" Text="Add Author"
        OnClick="AddAuthorButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelAddAuthorStatus" runat="server" Text=""></asp:Label>
    <p></p>

    <h3>Add Publisher:</h3>
        <table>
        <tr>
            <td>
                <asp:Label ID="LabelAddPublisherName" runat="server">Publisher Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddPublisherName"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9"
                    runat="server" Text="* Publisher name required."
                    ControlToValidate="AddPublisherName" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelAddPublisherWebsite" runat="server">Publisher Website:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddPublisherWebsite"
                    runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10"
                    runat="server" Text="* Website required."
                    ControlToValidate= "AddAuthorCountry" SetFocusOnError="true"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
        <asp:Button ID="AddPublisherButton" runat="server" Text="Add Publisher"
        OnClick="AddPublisherButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelAddPublisherStatus" runat="server" Text=""></asp:Label>
    <p></p>
    <h3>Remove Product:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelRemoveProduct"
                    runat="server">Product:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemoveProduct" runat="server"
                    
                    Type="PaperPhil.Models.Product"
                    SelectMethod="GetProducts" AppendDataBoundItems="true"
                    DataTextField="BookTitle" DataValueField="BookID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveProductButton" runat="server" Text="Remove Product"
        OnClick="RemoveProductButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>

        <h3>Remove Author:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelRemoveAuthor"
                    runat="server">Author:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemoveAuthor" runat="server"
                    ItemType="PaperPhil.Models.Author"
                    SelectMethod="GetAuthors" AppendDataBoundItems="true"
                    DataTextField="AuthorName" DataValueField="AuthorID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemoveAuthorButton" runat="server" Text="Remove Author"
        OnClick="RemoveAuthorButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelRemoveAuthorStatus" runat="server" Text=""></asp:Label>

        <h3>Remove Publisher:</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="LabelRemovePublisher"
                    runat="server">Publisher:</asp:Label></td>
            <td>
                <asp:DropDownList ID="DropDownRemovePublisher" runat="server"
                    ItemType="PaperPhil.Models.Publisher"
                    SelectMethod="GetPublishers" AppendDataBoundItems="true"
                    DataTextField="PublisherName" DataValueField="PublisherID">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <p></p>
    <asp:Button ID="RemovePublisherButton" runat="server" Text="Remove Publisher"
        OnClick="RemovePublisherButton_Click" CausesValidation="false" />
    <asp:Label ID="LabelRemovePublisherStatus" runat="server" Text=""></asp:Label>
</asp:Content>
