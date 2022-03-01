using CQRSMediatorApiProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CQRSMediatorApiProject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
