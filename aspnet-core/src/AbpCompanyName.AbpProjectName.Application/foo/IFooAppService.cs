﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.foo
{
    public interface IFooAppService
    {
        Task<FooQueryResponse> GetFoosAsync(FooQueryRequest request);
    }
}