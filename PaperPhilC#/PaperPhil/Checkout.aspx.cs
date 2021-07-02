using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaperPhil.Models;
using PaperPhil.Logic;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;

namespace PaperPhil
{
    public partial class Checkout : System.Web.UI.Page
    {
        private ProductContext _db = new ProductContext();
        private int generatedId;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                decimal cartTotal = 0;
                cartTotal = usersShoppingCart.GetTotal();
                if (cartTotal > 0)
                {
                    // Display Total.
                    lblTotal.Text = String.Format("{0:c}", cartTotal);
                }
            }
        }
        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    // Extract values from the cell.
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }
        public void CommitUserDetails()
        {
            ShoppingCartActions userTotal = new ShoppingCartActions();
            var myUser = new Order();
            myUser.FirstName = firstName.Text;
            myUser.LastName = lastName.Text;
            myUser.Address = address.Text;
            myUser.City = city.Text;
            myUser.State = state.Text;
            myUser.Country = country.Text;
            myUser.PostalCode = postalCode.Text;
            myUser.Phone = phone.Text;
            myUser.Email = email.Text;
            myUser.Total = userTotal.GetTotal();
            myUser.OrderDate = System.DateTime.Now;
            _db.Orders.Add(myUser);
            _db.SaveChanges();
            generatedId = myUser.OrderId;
        }
        public void CommitOrderDetails()
        {
            List<CartItem> cartItems = GetShoppingCartItems();
            using (ShoppingCartActions items = new ShoppingCartActions())
            {
                foreach (var cartItem in cartItems)
                {
                    var myOrderDetails = new OrderDetail();
                    myOrderDetails.OrderId = generatedId;
                    myOrderDetails.ProductId = cartItem.BookID;
                    myOrderDetails.Quantity = cartItem.Quantity;
                    myOrderDetails.UnitPrice = _db.Products.Where(v => v.BookID == cartItem.BookID).FirstOrDefault().UnitPrice;
                    myOrderDetails.OrderStatus = "Pending";
                    _db.OrderDetails.Add(myOrderDetails);
                    _db.SaveChanges();
                }
            }
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            CommitUserDetails();
            CommitOrderDetails();
            using (ShoppingCartActions emptyIt = new ShoppingCartActions())
            {
                emptyIt.EmptyCart();
            }
            
            Response.Redirect("Default.aspx");
        }

    }
}