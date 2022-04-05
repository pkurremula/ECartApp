using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECartInfra.Data;
using ECartCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECartAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Productsapicontroller : ControllerBase
    {
        private readonly StoreContext context;
        public Productsapicontroller(StoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var Products = await context.Products.ToListAsync();

            return Ok(Products);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await context.Products.FindAsync(id);
        }
    }
}