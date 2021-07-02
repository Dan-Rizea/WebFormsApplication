using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaperPhil.Models;

namespace PaperPhil.Logic
{
    public class AddAuthors
    {
        public bool AddAuthorsMethod(string AuthorName, string AuthorWebsite, string AuthorCountry)
        {
            var myAuthor = new Author();
            myAuthor.AuthorName = AuthorName;
            myAuthor.AuthorWebsite = AuthorWebsite;
            myAuthor.AuthorCountry = AuthorCountry;
            using (ProductContext _db = new ProductContext())
            {
                // Add author to DB.
                _db.Authors.Add(myAuthor);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}