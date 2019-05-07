using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpCompanyName.AbpProjectName.Controllers;
using System.Threading.Tasks;
using AbpCompanyName.AbpProjectName.foo;
using System.Collections.Generic;
using AbpCompanyName.AbpProjectName.Web.Models;

namespace AbpCompanyName.AbpProjectName.Web.Controllers
{
    [AbpMvcAuthorize]
    public class FooController : AbpProjectNameControllerBase
    {
        private readonly IFooAppService _fooAppService;

        public FooController(IFooAppService fooAppService)
        {
            _fooAppService = fooAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> FooQuery(string fooTypes)
        {
            var request = new FooQueryRequest
            {
                FooTypes = fooTypes
            };

            var response = await _fooAppService.GetFoosAsync(request);

            var model = ObjectMapper.Map<List<FooViewModel>>(response.FooItems);

            return PartialView("~/Views/Foo/FooList.cshtml", model);
        }
    }
}
