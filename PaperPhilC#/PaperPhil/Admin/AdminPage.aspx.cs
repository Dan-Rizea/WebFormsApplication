using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaperPhil.Models;
using PaperPhil.Logic;
namespace PaperPhil.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "addProduct")
            {
                LabelAddStatus.Text = "Product added!";
            }
            if (productAction == "addAuthor")
            {
                LabelAddAuthorStatus.Text = "Author added!";
            }
            if (productAction == "addPublisher")
            {
                LabelAddPublisherStatus.Text = "Publisher added!";
            }
            if (productAction == "removeProduct")
            {
                LabelRemoveStatus.Text = "Product removed!";
            }
            if (productAction == "removeAuthor")
            {
                LabelRemoveAuthorStatus.Text = "Author removed!";
            }
            if (productAction == "removePublisher")
            {
                LabelRemovePublisherStatus.Text = "Publisher removed!";
            }

        }
        protected void AddProductButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Content/Images/");
            if (ProductImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }
                // Add product data to DB.
                AddProducts products = new AddProducts();
                bool addSuccess = products.AddProduct(AddProductName.Text, AddProductRelease.Text, AddProductPrice.Text, AddProductISBN.Text, DropDownAddCategory.SelectedValue, DropDownAddAuthor.SelectedValue, DropDownAddPublisher.SelectedValue, ProductImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=addProduct");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new product to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }
        protected void AddAuthorButton_Click(object sender, EventArgs e)
        {
            AddAuthors authors = new AddAuthors();
            bool addSuccess = authors.AddAuthorsMethod(AddAuthorName.Text, AddAuthorWebsite.Text, AddAuthorCountry.Text);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ProductAction=addAuthor");
            }
            else
            {
                LabelAddAuthorStatus.Text = "Unable to add new author to database.";
            }

        }
        protected void AddPublisherButton_Click(object sender, EventArgs e)
        {
            AddPublishers publishers = new AddPublishers();
            bool addSuccess = publishers.AddPublishersMethod(AddPublisherName.Text, AddPublisherWebsite.Text);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ProductAction=addPublisher");
            }
            else
            {
                LabelAddPublisherStatus.Text = "Unable to add new publisher to database.";
            }

        }
        public IQueryable GetCategories()
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable query = _db.Categories;
            return query;
        }
        public IQueryable GetAuthors()
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable query = _db.Authors;
            return query;
        }
        public IQueryable GetPublishers()
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable query = _db.Publishers;
            return query;
        }
        public IQueryable GetProducts()
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable query = _db.Products;
            return query;
        }
        protected void RemoveProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PaperPhil.Models.ProductContext())
            {
                int productId = Convert.ToInt16(DropDownRemoveProduct.SelectedValue);
                var myItem = (from c in _db.Products where c.BookID == productId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Products.Remove(myItem);
                    _db.SaveChanges();
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=removeProduct");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }
        protected void RemoveAuthorButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PaperPhil.Models.ProductContext())
            {
                int authorId = Convert.ToInt16(DropDownRemoveAuthor.SelectedValue);
                var myItem = (from c in _db.Authors where c.AuthorID == authorId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Authors.Remove(myItem);
                    _db.SaveChanges();
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=removeAuthor");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate author.";
                }
            }
        }
        protected void RemovePublisherButton_Click(object sender, EventArgs e)
        {
            using (var _db = new PaperPhil.Models.ProductContext())
            {
                int publisherId = Convert.ToInt16(DropDownRemovePublisher.SelectedValue);
                var myItem = (from c in _db.Publishers where c.publisherID == publisherId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Publishers.Remove(myItem);
                    _db.SaveChanges();
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=removePublisher");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }


    }
}