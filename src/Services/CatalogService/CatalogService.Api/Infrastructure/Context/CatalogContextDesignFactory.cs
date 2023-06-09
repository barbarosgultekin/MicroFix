﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CatalogService.Api.Infrastructure.Context
{
    public class CatalogContextDesignFactory : IDesignTimeDbContextFactory<CatalogContext>
    {
        public CatalogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatalogContext>()
                .UseSqlServer("Data Source=DEVELOPEDB;Initial Catalog=catalog;Persist Security Info=True;User ID=sa;Password=b4rb4r0s");

            return new CatalogContext(optionsBuilder.Options);
        }
    }
}
