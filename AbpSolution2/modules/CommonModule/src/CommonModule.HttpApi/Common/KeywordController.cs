using Asp.Versioning;
using CommonModule.Common;
using CommonModule.Common.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSolution2.Controllers.Common
{
    [RemoteService]
    [Area("app")]
    [ControllerName("Keyword")]
    [Route("api/app/keyword")]

    public class KeywordController : AbpController
    {
        protected IKeywordAppService _keywordAppService;

        public KeywordController(IKeywordAppService keywordAppService) => _keywordAppService = keywordAppService;

        [HttpGet]
        public virtual Task<PagedResultDto<KeywordDto>> GetListAsync(PagedCommonResultRequestDto input)
        {
            return _keywordAppService.GetListAsync(input);
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<KeywordDto> GetAsync(int id)
        {
            return _keywordAppService.GetAsync(id);
        }

        [HttpPost]
        public virtual Task<KeywordDto> CreateAsync(KeywordDto input)
        {
            return _keywordAppService.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<KeywordDto> UpdateAsync(int id, KeywordDto input)
        {
            return _keywordAppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(int id)
        {
            return _keywordAppService.DeleteAsync(id);
        }
    }
}