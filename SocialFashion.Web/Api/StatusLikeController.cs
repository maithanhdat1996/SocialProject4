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
    [RoutePrefix("api/statuslike")]
    public class StatusLikeController : ApiControllerBase
    {
        IStatusLikeService _statusLikeService;

        public StatusLikeController(ILogService logService, IStatusLikeService statusLikeService) :
            base(logService)
        {
            this._statusLikeService = statusLikeService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listStatusLike = _statusLikeService.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listStatusLike);


                return response;
            });
        }
        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, StatusLike sl)
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
                    var statusLike = _statusLikeService.Add(sl);
                    _statusLikeService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, statusLike);

                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, StatusLike sl)
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
                    _statusLikeService.Update(sl);
                    _statusLikeService.SaveChanges();

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
                    _statusLikeService.Delete(id);
                    _statusLikeService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}