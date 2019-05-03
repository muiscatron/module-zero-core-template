using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.foo.Dto
{
    public class FooItemDto : EntityDto
    {
        public string FooName { get; set; }
        public string FooNickname { get; set; }
        public decimal FooDensity { get; set; }
    }
}
