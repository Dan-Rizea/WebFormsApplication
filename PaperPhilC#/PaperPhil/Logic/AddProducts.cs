using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaperPhil.Models;

namespace PaperPhil.Logic
{
    public class AddProducts
    {
        public bool AddProduct(string ProductName, string ProductRelease, string ProductPrice, string ProductISBN, string ProductCategory, string ProductAuthor, string ProductPublisher, string ProductImagePath)
        {
            var myProduct = new Product();
            myProduct.BookTitle = ProductName;
            myProduct.BookRelease = Convert.ToInt32(ProductRelease);
            myProduct.UnitPrice = Convert.ToDouble(ProductPrice);
            myProduct.ImagePath = ProductImagePath;
            myProduct.ISBN = ProductISBN;
            myProduct.CategoryID = Convert.ToInt32(ProductCategory);
            myProduct.PublisherID = Convert.ToInt32(ProductPublisher);
            myProduct.AuthorID = Convert.ToInt32(ProductAuthor);
            using (ProductContext _db = new ProductContext())
            {
                // Add product to DB.
                _db.Products.Add(myProduct);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}
