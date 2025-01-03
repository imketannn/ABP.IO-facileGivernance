using System;
using AbpSolution2.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpSolution2.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = AbpSolution2Permissions.Books.Default;
        GetListPolicyName = AbpSolution2Permissions.Books.Default;
        CreatePolicyName = AbpSolution2Permissions.Books.Create;
        UpdatePolicyName = AbpSolution2Permissions.Books.Edit;
        DeletePolicyName = AbpSolution2Permissions.Books.Delete;
    }
}