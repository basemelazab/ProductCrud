using ProductCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductCrud.Controllers
{
    public class ProductController : ApiController
    {

        ProductDataBaseEntities db = new ProductDataBaseEntities();
        public String Post(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return "Product Added Successfully.";
        }

    }
}
