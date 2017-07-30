using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : ApiController
    {

        private static List<Product> productList = new List<Product>();
        
       

        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return productList;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
           foreach(Product p in productList)
            {
                int productId = int.Parse(p.Id);
                if (productId == id)
                {
                    return p;
                }
            }
            
            return null;
        }

        // POST: api/Product
        public string Post(Product product)
        {
            productList.Add(product);
            return "success";
        }

        // PUT: api/Product/5
        public string Put(int id, Product product)
        {
            foreach(Product p in productList)
            {
                int productId = int.Parse(p.Id);
                if (productId == id)
                {
                    p.Id = product.Id;
                    p.Model = product.Model;
                    p.Brand = product.Brand;
                    p.Description = product.Description;
                    return "success";
                }
            }
            return "no data to update";
        }

        // DELETE: api/Product/5
        public string Delete(int id)
        {
                foreach (Product p in productList)
                {
                    int productId = int.Parse(p.Id);
                    if (productId == id)
                    {
                        productList.Remove(p);
                    return "success";
                    }
                }

            return "no data to delete";

        }
        
        
    }
}
