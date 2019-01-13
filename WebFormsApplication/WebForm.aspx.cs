using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using WebModel;

namespace WebFormsApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static Customer handleAjaxRequest(Customer customer)
        {
            return new Customer
            {
                ID = 59,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                CreationTime = System.DateTime.Now.ToString()
            };

        }
    }
}