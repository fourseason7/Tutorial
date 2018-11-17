using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private List<ProductsModel> products = new List<ProductsModel>()
        {
            new ProductsModel {Id = 1, Name = "T Shirt", Price = 26.5M, Qty = 5 },
            new ProductsModel {Id = 2, Name = "T Shirt2", Price = 12.5M, Qty = 2 },
            new ProductsModel {Id = 3, Name = "T Shirt3", Price = 19.95M, Qty = 3 }
        };

        public IEnumerable<ProductsModel> Get()
        {
            return products.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            //return products.Where(x => x.Id == id);
            //var product = products.Where(x => x.Id == id);
            var product = (from a in products
                           where a.Id == id
                           select a).FirstOrDefault();

            if (product == null)
                return NotFound();
            return Ok(product);
        }


    }
}
