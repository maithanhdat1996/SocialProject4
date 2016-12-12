using SocialFashion.Model.Models;
using SocialFashion.Service;
using SocialFashion.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SocialFashion.Web.Api
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiControllerBase
    {
        IProductService _productService;

        public ProductController(ILogService logService, IProductService productService) :
            base(logService)
        {
            this._productService = productService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                
                var listProduct = _productService.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProduct);

                
                return response;
            });
        }

        [HttpGet]
        [Route("testgetallproduct")]
        public HttpResponseMessage TestGetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listProductAll = _productService.TestGetAllProduct();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductAll);


                return response;
            });
        }

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, Product p)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var product = _productService.Add(p);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, product);

                }
                return response;
            });
        }
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, Product p)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _productService.Update(p);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
        [HttpDelete]
        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _productService.Delete(id);
                    _productService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}