using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries
{
    public class GetProducts : IRequest<List<ProductVm>>
    {
    }

    public class GetProductsHandler : IRequestHandler<GetProducts, List<ProductVm>>
    {
        private readonly IApplicationDbContext _context;
        public GetProductsHandler(IApplicationDbContext context) 
        {
            this._context = context;
        }
        public async Task<List<ProductVm>> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var items = await _context.Products.Select(x => new ProductVm 
            {
                ProductName = x.ProductName,
                Description = x.Description,
                Price = x.Price,
                Quantity = x.Quantity
            }).ToListAsync(cancellationToken);
            return items;
        }
    }
}
