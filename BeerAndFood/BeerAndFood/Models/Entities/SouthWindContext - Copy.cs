using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeerAndFood.Models.Entities
{
    public partial class SouthWindContext : DbContext
    {
        public SouthWindContext(DbContextOptions<SouthWindContext> options) : base(options)
        {
        }
    }
}
