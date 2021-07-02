using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaperPhil.Models;

namespace PaperPhil.Logic
{
    public class AddPublishers
    {
        public bool AddPublishersMethod(string PublisherName, string PublisherWebsite)
        {
            var myPublisher = new Publisher();
            myPublisher.publisherName = PublisherName;
            myPublisher.publisherWebsite = PublisherWebsite;
            using (ProductContext _db = new ProductContext())
            {
                // Add author to DB.
                _db.Publishers.Add(myPublisher);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }

}
