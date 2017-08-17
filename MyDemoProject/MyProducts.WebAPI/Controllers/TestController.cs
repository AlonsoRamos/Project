using MyProducts.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace MyProducts.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:64277", headers: "*", methods: "*")]
    public class TestController : ApiController
    {
        private MyCompanyEntities db = new MyCompanyEntities();
        //GET: api/Product
        public IEnumerable<Object> Get()
        {
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

        //public HttpResponseMessage Get()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("GET: Test message")
        //    };
        //}

        //public HttpResponseMessage Post()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("POST: Test message")
        //    };
        //}

        //public HttpResponseMessage Put()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("PUT: Test message")
        //    };
        //}

    }
}