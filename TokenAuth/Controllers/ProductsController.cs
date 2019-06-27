using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenAuth.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Authorize]
        public List<string> List()
        {
            List<string> products = new List<string>();

            products.Add("Apple");
            products.Add("Samsung");
            products.Add("Huawei");

            return products;
        }
    }
}
