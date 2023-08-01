using Etreade.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Dal
{
    public class TreadContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasketDetail>()
                .HasKey(b => new { b.BasketId, b.ProductId });
                
        }
        public TreadContext(DbContextOptions<TreadContext> db):base(db) 
        {
            

        }
        DbSet<BasketDetail> BasketDetailSet { get; set;}
        DbSet<BaskitMaster> BaskitMasters { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<Suppliers> Suppliers { get; set; }
        DbSet<Categories> Categories { get; set; }
        DbSet<Products> Products { get; set; }

    }
}
