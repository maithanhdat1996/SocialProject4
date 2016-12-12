using SocialFashion.Model.Models;
using SocialFashion.Service;
using SocialFashion.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SocialFashion.Web.Api
{
    [RoutePrefix("api/producttype")]
    public class ProductTypeController : ApiControllerBase
    {
        IProductTypeService _productTypeService;
        public ProductTypeController(ILogService logService, IProductTypeService productTypeService) :
            base(logService)
        {
            this._productTypeService = productTypeService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listProductType = _productTypeService.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listProductType);


                return response;
            });
        }
        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, ProductType pt)
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
                    var order = _productTypeService.Add(pt);
                    _productTypeService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, order);

                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, ProductType pt)
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
                    _productTypeService.Update(pt);
                    _productTypeService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
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
                    _productTypeService.Delete(id);
                    _productTypeService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }

}