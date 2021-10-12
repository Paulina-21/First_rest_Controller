using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_rest_Controller.Models;
using Microsoft.EntityFrameworkCore;

namespace First_rest_Controller.AppDbContext
{
    public class ItemContext:DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
