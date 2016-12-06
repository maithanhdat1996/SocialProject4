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
    [RoutePrefix("api/statuscomment")]
    public class StatusCommentController : ApiControllerBase
    {
        IStatusCommentService _statusCommentService;

        public StatusCommentController(ILogService logService, IStatusCommentService statusCommentService) :
            base(logService)
        {
            this._statusCommentService = statusCommentService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listStatusComment = _statusCommentService.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listStatusComment);


                return response;
            });
        }
        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, StatusComment sc)
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
                    var statusCommnent = _statusCommentService.Add(sc);
                    _statusCommentService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, statusCommnent);

                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, StatusComment sc)
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
                    _statusCommentService.Update(sc);
                    _statusCommentService.SaveChanges();

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
                    _statusCommentService.Delete(id);
                    _statusCommentService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}