using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaperPhil.Models;
using System.Web.ModelBinding;
using System.Collections.Specialized;

namespace PaperPhil
{
    public partial class ViewCompletedOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "resetOrder")
            {
                LabelReset.Text = "Order Reset!";
            }
            if (productAction == "cancelOrder")
            {
                LabelCancel.Text = "Order Cancelled!";
            }

        }
        public IQueryable<Order> GetUser()
        {
            var _db = new PaperPhil.Models.ProductContext();
            var detail = new OrderDetail();
            IQueryable<Order> query = _db.Orders.Where(v => v.OrderId == (from c in _db.OrderDetails where c.OrderId == v.OrderId && c.OrderStatus == "Completed" select c.OrderId).FirstOrDefault());
            return query;
        }

        protected void ResetOrderBtn_Click(object sender, EventArgs e)
        {
            using (var _db = new PaperPhil.Models.ProductContext())
            {
                int orderId = Convert.ToInt16(DropDownReset.SelectedValue);
                var getOrder = (from c in _db.OrderDetails where c.OrderId == orderId select c);
                for (int i = 0; i < getOrder.Count(); i++)
                {
                    var myItem = (from c in _db.OrderDetails where c.OrderId == orderId && c.OrderStatus == "Completed" select c).FirstOrDefault();
                    myItem.OrderStatus = "Pending";
                    _db.SaveChanges();
                }
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ProductAction=resetOrder");
            }
        }

        protected void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            using (var _db = new PaperPhil.Models.ProductContext())
            {
                int orderId = Convert.ToInt16(DropDownCancel.SelectedValue);
                var getOrder = (from c in _db.OrderDetails where c.OrderId == orderId select c);
                for (int i = 0; i < getOrder.Count(); i++)
                {
                    var myItem = (from c in _db.OrderDetails where c.OrderId == orderId && c.OrderStatus == "Completed" select c).FirstOrDefault();
                    myItem.OrderStatus = "Cancelled";
                    _db.SaveChanges();
                }
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ProductAction=cancelOrder");
            }
        }
    }
}