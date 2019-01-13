using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using WebModel;

namespace WebService
{
    /// <summary>
    /// Summary description for CustomerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class CustomerService : System.Web.Services.WebService
    {

        [WebMethod]        
        public Customer GetCustomer(Customer customer)
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
