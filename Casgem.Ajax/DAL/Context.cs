﻿using Microsoft.EntityFrameworkCore;

namespace Casgem.Ajax.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-13123BI; Initial Catalog=CasgemAjaxDB; Integrated Security=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}