using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaperPhil.Models;
using System.Web.ModelBinding;


namespace PaperPhil
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var _db = new PaperPhil.Models.Product();
        }
        public IQueryable<Product> GetProduct([QueryString("BookID")] int? productId)
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.BookID == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }
        public IQueryable<Author> GetAuthor([QueryString("BookID")] int? productId)
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable<Author> query = _db.Authors;
            IQueryable<Product> query1 = _db.Products;
            int? author;
            if (productId.HasValue && productId > 0)
            {
                author = query1.Where(v => v.BookID == productId).FirstOrDefault().AuthorID;
                query = query.Where(x => x.AuthorID == author);
            }
            else
            {
                query = null;
            }
            return query;
        }
        public IQueryable<Publisher> GetPublisher([QueryString("BookID")] int? productId)
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable<Publisher> query = _db.Publishers;
            IQueryable<Product> query1 = _db.Products;
            int? publisher;
            if (productId.HasValue && productId > 0)
            {
                publisher = query1.Where(v => v.BookID == productId).FirstOrDefault().PublisherID;
                query = query.Where(p => p.publisherID == publisher);
            }
            else
            {
                query = null;
            }
            return query;
        }



    }
}