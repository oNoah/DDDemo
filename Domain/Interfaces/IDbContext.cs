using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Domain.Interfaces
{
    public class IDbContext : DbContext
    {
        public IDbContext(DbContextOptions options)
            : base(options)
        {

        }
        //private DbContextOptionsBuilder _options;
        //private readonly string connectionString;
        //public IDbContext(string nameOrConnectionString)
        //{
        //    connectionString = nameOrConnectionString;
        //}

        //public IDbContext(DbContextOptionsBuilder builder)
        //{
        //    _options = builder;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // 从 appsetting.json 中获取配置信息
        //    var config = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();


        //    optionsBuilder.UseSqlServer(config.GetConnectionString(connectionString));
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
