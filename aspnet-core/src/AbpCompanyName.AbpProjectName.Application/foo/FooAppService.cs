using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.foo
{
    public class FooAppService : AbpProjectNameAppServiceBase, IFooAppService
    {
        public async Task<FooQueryResponse> GetFoosAsync(FooQueryRequest request)
        {

            var dummyData = new FooQueryResponse
            {
                FooItems = new List<Dto.FooItemDto>
                {
                    new Dto.FooItemDto { Id = 1, FooName = "AAAAA", FooNickname = "Aaaaaaaaa", FooDensity = 1.0M },
                    new Dto.FooItemDto { Id = 2, FooName = "BBBBB", FooNickname = "Bbbbbbbbb", FooDensity = 2.0M },
                    new Dto.FooItemDto { Id = 3, FooName = "CCCCC", FooNickname = "Ccccccccc", FooDensity = 3.0M },
                    new Dto.FooItemDto { Id = 4, FooName = "DDDDD", FooNickname = "Ddddddddd", FooDensity = 4.0M },
                    new Dto.FooItemDto { Id = 5, FooName = "EEEEE", FooNickname = "Eeeeeeeee", FooDensity = 5.0M },
                    new Dto.FooItemDto { Id = 6, FooName = "FFFFF", FooNickname = "Fffffffff", FooDensity = 6.0M }
                }
            };

            return dummyData;

        }
    }
}
