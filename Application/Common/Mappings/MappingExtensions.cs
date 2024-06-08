using Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mappings
{
    public static class MappingExtensions
    {
        public static Task<PaginationList<TDestination>> PaginationListAsync<TDestination>(this IQueryable<TDestination> source, int pageNumber, int pageSize)
            => PaginationList<TDestination>.CreatePaginationAsync(source, pageNumber, pageSize);
    }
}
