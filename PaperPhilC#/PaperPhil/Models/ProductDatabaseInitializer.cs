using System.Collections.Generic;
using System.Data.Entity;
namespace PaperPhil.Models
{
    public class ProductDatabaseInitializer :
    DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
            GetAuthors().ForEach(x => context.Authors.Add(x));
            GetPublishers().ForEach(z => context.Publishers.Add(z));
        }
        private static List<Category> GetCategories()
         {
            var categories = new List<Category> {
             new Category
             {
             CategoryID = 1,
             CategoryName = "Popular Books"
             },
             new Category
             {
             CategoryID = 2,
             CategoryName = "Arts & Photography"
             },
             new Category
             {
             CategoryID = 3,
             CategoryName = "Thrillers & Crime Biography & Memoir"
             },
             new Category
             {
             CategoryID = 4,
             CategoryName = "Nonfiction"
             },
             new Category
             {
             CategoryID = 5,
             CategoryName = "Business & Investing"
             },
             new Category
             {
             CategoryID = 6,
             CategoryName = "Poetry"
             },
             new Category
             {
             CategoryID = 7,
             CategoryName = "Children's Books"
             },
             new Category
             {
             CategoryID = 8,
             CategoryName = "Romance"
             },
             new Category
             {
             CategoryID = 9,
             CategoryName = "Comics & Graphic Novels"
             },
             new Category
             {
             CategoryID = 10,
             CategoryName = "Science Fiction"
             },
             new Category
             {
             CategoryID = 11,
             CategoryName = "Cooking & Wine"
             },
             new Category
             {
             CategoryID = 12,
             CategoryName = "Science & Technology"
             },
             new Category
             {
             CategoryID = 13,
             CategoryName = "Fantasy"
             },
             new Category
             {
             CategoryID = 14,
             CategoryName = "Self Development & Hobbies"
             },
              new Category
             {
             CategoryID = 15,
             CategoryName = "History"
             },
               new Category
             {
             CategoryID = 16,
             CategoryName = "Horror"
             },
                new Category
             {
             CategoryID = 17,
             CategoryName = "Spirituality & Religion"
             },
                 new Category
             {
             CategoryID = 18,
             CategoryName = "Humor & Games"
             },
                  new Category
             {
             CategoryID = 19,
             CategoryName = "Teen & Young Adult Literature & Fiction"
             },

        };
        return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
             new Product
             {
             BookID = 1,
             BookTitle = "Crime & Punishment",
             BookRelease = 1866,
             ImagePath="crimeandpunishment.jpg",
             UnitPrice = 22.50,
             CategoryID = 19,
             AuthorID = 1,
             PublisherID = 1,
             ISBN = "9780143107637"
             },
             new Product
             {
             BookID = 2,
             BookTitle = "Sapiens",
             BookRelease = 2011,
             ImagePath="sapiens.jpg",
             UnitPrice = 15.95,
             CategoryID = 15,
             AuthorID = 5,
             PublisherID = 2,
             ISBN = "9780062316097"
             },
             new Product
             {
             BookID = 3,
             BookTitle = "The Brothers Karamazov",
             BookRelease = 1880,
             ImagePath="karamazov.jpg",
             UnitPrice = 32.99,
             CategoryID = 19,
             AuthorID = 1,
             PublisherID = 1,
             ISBN = "0374528373"
             },
             new Product
             {
             BookID = 4,
             BookTitle = "Thinking Fast, And Slow",
             BookRelease = 2011,
             ImagePath="thinking.jpg",
             UnitPrice = 8.95,
             CategoryID = 4,
             AuthorID = 9,
             PublisherID = 4,
             ISBN = "0374533555"
             },
             new Product
             {
             BookID = 5,
             BookTitle = "Homo Deus",
             BookRelease = 2015,
             ImagePath = "homodeus.jpg",
             UnitPrice = 34.95,
             CategoryID = 12,
             AuthorID = 5,
             PublisherID = 3,
             ISBN = "1910701882"
             },
             new Product
             {
             BookID = 6,
             BookTitle = "The Black Swan",
             BookRelease = 2010,
             ImagePath="blackswan.jpeg",
             UnitPrice = 21.00,
             CategoryID = 4,
             AuthorID = 6,
             PublisherID = 4,
             ISBN = "0141034599"
             },
             new Product
             {
             BookID = 7,
             BookTitle = "21 Rules for the 21st Century",
             BookRelease = 2018,
             ImagePath="harari.png",
             UnitPrice = 4.95,
             CategoryID = 4,
             AuthorID = 5,
             PublisherID = 5,
             ISBN = "9781787330672"
             },
             new Product
             {
             BookID = 8,
             BookTitle = "Mistborn: The Well of Ascension",
             BookRelease = 2007,
             ImagePath="mistborn.jpg",
             UnitPrice = 22.95,
             CategoryID = 13,
             AuthorID = 2,
             PublisherID = 6,
             ISBN = "0765356139"
             },
             new Product
             {
             BookID = 9,
             BookTitle = "Thus Spoke Zarathustra",
             BookRelease = 1885,
             ImagePath="nietzsche.jpg",
             UnitPrice = 32.95,
             CategoryID = 17,
             AuthorID = 3,
             PublisherID = 7,
             ISBN = "9780140441185"
             },
             new Product
             {
             BookID = 10,
             BookTitle = "Antifragile",
             BookRelease = 2012,
             ImagePath= "antifragile.jpeg",
             UnitPrice = 15.00,
             CategoryID = 4,
             AuthorID = 6,
             PublisherID = 4,
             ISBN = "0812979680"
             },
             new Product
             {
             BookID = 11,
             BookTitle = "On Liberty",
             BookRelease = 1859,
             ImagePath= "libertymill.jpg",
             UnitPrice = 26.00,
             CategoryID = 4,
             AuthorID = 8,
             PublisherID = 8,
             ISBN = "9780140432077"
             },
             new Product
             {
             BookID = 12,
             BookTitle = "Notes from Underground",
             BookRelease = 1864,
             ImagePath="notesfromunderground.jpg",
             UnitPrice = 29.00,
             CategoryID = 19,
             AuthorID = 1,
             PublisherID = 1,
             ISBN = "0451529553"
             },
             new Product
             {
             BookID = 13,
             BookTitle = "Oathbringer",
             BookRelease = 2017,
             ImagePath="oathbringer.jpg",
             UnitPrice = 23.00,
             CategoryID = 13,
             AuthorID = 2,
             PublisherID = 6,
             ISBN = "9788417347000"
             },
             new Product
             {
             BookID = 14,
             BookTitle = "The Sickness unto Death",
             BookRelease = 1849,
             ImagePath="kierkegaard.jpg",
             UnitPrice = 4.95,
             CategoryID = 4,
             AuthorID = 4,
             PublisherID = 9,
             ISBN = "0140445331"
             },
             new Product
             {
             BookID = 15,
             BookTitle = "Elantris",
             BookRelease = 2005,
             ImagePath="elantris.jpg",
             UnitPrice = 42.95,
             CategoryID = 13,
             AuthorID = 2,
             PublisherID = 6,
             ISBN = "0765350378"
             },
             new Product
             {
             BookID = 16,
             BookTitle = "The Gulag Archipelago",
             BookRelease = 1973,
             ImagePath="gulag.jpg",
             UnitPrice = 12.95,
             CategoryID = 5,
             AuthorID = 7,
             PublisherID = 10,
             ISBN = "9781784871512"
             }
             };
             return products;
             }
        private static List<Author> GetAuthors()
        {
            var authors = new List<Author>
            {
                new Author
                {
                    AuthorID = 1,
                    AuthorName = "Fyodor Dostoevski",
                    AuthorCountry = "Russia",
                    AuthorWebsite = null,
                },
                new Author
                {
                    AuthorID = 2,
                    AuthorName = "Brandon Sanderson",
                    AuthorCountry = "USA",
                    AuthorWebsite = "https://www.brandonsanderson.com/"
                },
                new Author
                {
                    AuthorID = 3,
                    AuthorName = "Friedrich Nietzsche",
                    AuthorCountry = "Prussia",
                    AuthorWebsite = null
                },
                new Author
                {
                    AuthorID = 4,
                    AuthorName = "Soren Kierkegaard",
                    AuthorCountry = "Denmark",
                    AuthorWebsite = null
                },
                new Author
                {
                    AuthorID = 5,
                    AuthorName = "Yuval Noah Harari",
                    AuthorCountry = "Israel",
                    AuthorWebsite = "https://www.ynharari.com/"
                },
                new Author
                {
                    AuthorID = 6,
                    AuthorName = "Nassim Taleb",
                    AuthorCountry = "Lebanon",
                    AuthorWebsite = "https://www.fooledbyrandomness.com/"
                },
                new Author
                {
                    AuthorID = 7,
                    AuthorName = "Aleksandr Solzhenitsyn",
                    AuthorCountry = "Russia",
                    AuthorWebsite = null
                },
                new Author
                {
                    AuthorID = 8,
                    AuthorName = "John Stewart Mill",
                    AuthorCountry = "England",
                    AuthorWebsite = null
                },
                new Author
                {
                    AuthorID = 9,
                    AuthorName = "Daniel Kahneman",
                    AuthorCountry = "Israel",
                    AuthorWebsite = null
                }
            };
            return authors;
        }
        private static List<Publisher> GetPublishers()
        {
            var publishers = new List<Publisher>
            {
                new Publisher
                {
                    publisherID = 1,
                    publisherName = "The Russian Messenger",
                    publisherWebsite = null
                },
                new Publisher
                {
                    publisherID = 2,
                    publisherName = "Dvir Publishing House Ltd. (Israel) Harper",
                    publisherWebsite = null
                },
                new Publisher
                {
                    publisherID = 3,
                    publisherName = "Harvill Secker",
                    publisherWebsite = null
                },
                new Publisher
                {
                    publisherID = 4,
                    publisherName = "Random House",
                    publisherWebsite = "https://www.penguinrandomhouse.com/"
                },
                new Publisher
                {
                    publisherID = 5,
                    publisherName = "Spiegel & Grau",
                    publisherWebsite = "https://www.spiegelandgrau.com"
                },
                new Publisher
                {
                    publisherID = 6,
                    publisherName = "Tor Books",
                    publisherWebsite = "https://www.tor.com/"
                },
                new Publisher
                {
                    publisherID = 7,
                    publisherName = "Ernst Schmeitzner",
                    publisherWebsite = null
                },
                new Publisher
                {
                    publisherID = 8,
                    publisherName = "Cambridge University Press",
                    publisherWebsite = null
                },
                new Publisher
                {
                    publisherID = 9,
                    publisherName = "Simon & Schuster",
                    publisherWebsite = "https://www.simonandschuster.com/"
                },
                new Publisher
                {
                    publisherID = 10,
                    publisherName = "Éditions du Seuil",
                    publisherWebsite = "https://www.seuil.com/"
                }
            };
            return publishers;
        }
    }
}

