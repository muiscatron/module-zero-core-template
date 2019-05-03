using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpCompanyName.AbpProjectName.Controllers;
using System.Threading.Tasks;
using AbpCompanyName.AbpProjectName.foo;

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

            // var holdingsModel = this.AggregatePortfolioHoldings(ObjectMapper.Map<List<HoldingModel>>(response.Holdings));

            // return PartialView("~/Views/Clients/Tab/SubTabs/_PortfolioHoldings.cshtml", holdingsModel);

            return null;

        }


    }
}
