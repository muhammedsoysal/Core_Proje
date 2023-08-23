using Core_Proje_Api.DAL.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.DAL.Context
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-124H4QM2;Database=CoreProjeDbApi;integrated security=true");
        }
        public DbSet<Category>Categories{ get; set; }
    }
}
