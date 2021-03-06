﻿using MyProducts.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace MyProducts.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:64277", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private MyCompanyEntities db = new MyCompanyEntities();
        // GET: api/Product
        public IEnumerable<Object> Get()
        {
            //var x = db.Products.AsEnumerable();
            //return x.ToList();
            var myObjects = (from prod in db.Products
                             join img in db.ProductImages on prod.Id equals img.ProductId
                             select new
                             {
                                 prod.Model,
                                 prod.Price,
                                 prod.Description,
                                 img.ImagURL
                             }).ToList();
            return myObjects;
        }

        #region other methods
        // GET: api/Product/5
        public string Get(int id)
        {
            var product = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return product.ToString();
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
    #endregion

}