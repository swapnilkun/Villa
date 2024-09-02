﻿using FlipCart.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FlipCart.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

       public DbSet<Catagory> catagories {  get; set; }
    }
}
