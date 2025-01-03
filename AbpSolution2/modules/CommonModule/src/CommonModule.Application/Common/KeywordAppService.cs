using CommonModule.Common.Dto;
using CommonModule.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CommonModule.Common;

public class KeywordAppService : CrudAppService<
        Keyword, //The Keyword entity
        KeywordDto, //Used to show Keywords
        int, //Primary key of the Keyword entity
        PagedCommonResultRequestDto, //Used for paging/sorting/filter
        KeywordDto>, //Used to create/update a Keyword
    IKeywordAppService //implement the IKeywordAppService
{

    private readonly IRepository<Keyword> _keywordRepository;
    public KeywordAppService(IRepository<Keyword, int> repository)
        : base(repository)
    {
        GetPolicyName = CommonModulePermissions.Keyword.Default;
        GetListPolicyName = CommonModulePermissions.Keyword.Default;
        CreatePolicyName = CommonModulePermissions.Keyword.Create;
        UpdatePolicyName = CommonModulePermissions.Keyword.Edit;
        DeletePolicyName = CommonModulePermissions.Keyword.Delete;
        _keywordRepository = repository;
    }

    protected override async Task<IQueryable<Keyword>> CreateFilteredQueryAsync(PagedCommonResultRequestDto input)
    {
        var query = await _keywordRepository.GetQueryableAsync();
        query = query.WhereIf(input.IdentyType != 0, x => ((int)x.IdentyType) == input.IdentyType)
            .WhereIf(!string.IsNullOrEmpty(input.Keyword), x => x.Name.Contains(input.Keyword))
            .OrderBy(input.Sorting ?? "creationTime desc");

        return query;
    }

    public async Task<List<KeywordDto>> getKeywordBySearchAsync(PagedCommonResultRequestDto input)
    {
        var query = await _keywordRepository.GetQueryableAsync();

        var result = query
            .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword))
            .ToList();

        return ObjectMapper.Map<List<Keyword>, List<KeywordDto>>(result);
    }

    public override async Task<PagedResultDto<KeywordDto>> GetListAsync(PagedCommonResultRequestDto input)
    {
        var query = await _keywordRepository.GetQueryableAsync();
        query = query
            .WhereIf(input.IdentyType != 0, x => ((int)x.IdentyType) == input.IdentyType)
            .WhereIf(!string.IsNullOrEmpty(input.Keyword), x => x.Name.ToLower().Contains(input.Keyword.ToLower()))
            .OrderBy(input.Sorting ?? "creationTime desc");

        var keywords = query.PageBy(input).ToList();
        var totalCount = query.Count();

        var result = ObjectMapper.Map<List<Keyword>, List<KeywordDto>>(keywords);
        return await Task.FromResult(new PagedResultDto<KeywordDto>(totalCount, result));
    }

    public async Task<List<KeywordDto>> GetAllContentKeywordsAsync(PagedCommonResultRequestDto input)
    {
        var query = await _keywordRepository.GetQueryableAsync();
        var contentKeywords = query
            .WhereIf(input.IdentyType != 0, x => ((int)x.IdentyType) == input.IdentyType)
            .WhereIf(!string.IsNullOrEmpty(input.Keyword), x => x.Name.Contains(input.Keyword))
            .Take(5)
            .OrderBy(x => x.Id)
            .ToList();

        return ObjectMapper.Map<List<Keyword>, List<KeywordDto>>(contentKeywords);
    }

    public async Task<List<KeywordDto>> GetProspectKeywordsBySearchAsync(PagedCommonResultRequestDto input)
    {
        var query = await _keywordRepository.GetQueryableAsync();
        var prospectKeywords = query
           .WhereIf(input.IdentyType != 0, x => ((int)x.IdentyType) == input.IdentyType)
           .WhereIf(!string.IsNullOrEmpty(input.Keyword), x => x.Name.Contains(input.Keyword))
           .OrderBy(x => x.Id)
           .ToList();

        return ObjectMapper.Map<List<Keyword>, List<KeywordDto>>(prospectKeywords);
    }
}
