using Twenty_Crm_Application.Common.Models.Dto;

namespace Twenty_Crm_Application.Common.Mapping;

public static class MappingExtention
{
    public static Task<PaginatedList<TDestination>> PaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize) where TDestination : class
     => PaginatedList<TDestination>.CreateAsync(queryable.AsNoTracking(), pageNumber, pageSize);

}
