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
    [RoutePrefix("api/branch")]
    public class BranchController : ApiControllerBase
    {
        IBranchService _branchService;
        public BranchController(ILogService logService, IBranchService branchService) :
            base(logService)
        {
            this._branchService = branchService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listBranch = _branchService.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listBranch);


                return response;
            });
        }
        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, Branch b)
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
                    var branch = _branchService.Add(b);
                    _branchService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, branch);

                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, Branch b)
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
                    _branchService.Update(b);
                    _branchService.SaveChanges();

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
                    _branchService.Delete(id);
                    _branchService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}