using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaperPhil.Models;
using System.Web.ModelBinding;

namespace PaperPhil.Admin
{
    public partial class DetailedOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public IQueryable<OrderDetail> GetOrder([QueryString("OrderId")] int? orderId)
        {
            var _db = new PaperPhil.Models.ProductContext();
            IQueryable<OrderDetail> query = _db.OrderDetails;
            if (orderId.HasValue && orderId > 0)
            {
                query = query.Where(p => p.OrderId == orderId);
            }
            else
            {
                query = null;
            }
            return query;
        }

    }
}