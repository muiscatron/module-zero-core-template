using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.foo.Dto
{
    public class FooAppService : AbpProjectNameAppServiceBase, IFooAppService
    {
        public Task<FooQueryResponse> GetFoosAsync(FooQueryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
