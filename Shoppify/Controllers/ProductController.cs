using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries;
using Domain;
using Infrastructure.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shoppify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;
        public ProductController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<PaginationList<ProductVm>>> Get([FromQuery] GetProducts query)
        {
            var result = await Mediator.Send(query);
            return result;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]   
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]

        public async Task<int> Post([FromBody] CreateProductCommand command, CancellationToken cancellationToken)
        {
            //return await Mediator.Send(command, cancellationToken);

            var result = await Mediator.Send(command, cancellationToken);
            return result;
        }

        //public async Task<string> Post([FromBody] Product product)
        //{
        //    //CancellationToken cancellationToken = new CancellationToken();
        //    //var entity = new Product();
        //    //entity.ProductName = product.ProductName;
        //    //entity.Description = product.Description;
        //    //entity.Price = product.Price;
        //    //entity.CreatedAt = DateTime.Now;

        //    ///*
        //    ////ApplicationDbContext dbContext = new ApplicationDbContext();
        //    ////dbContext.Add<Product> (entity);
        //    ////dbContext.SaveChanges();
        //    //*/

        //    //_dbContext.Products.Add(entity);
        //    //await _dbContext.SaveChangesAsync(cancellationToken);
        //    return "Data Inserted Successfully";
        //}

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
