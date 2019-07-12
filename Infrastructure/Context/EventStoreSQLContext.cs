using Domain.Core.Events;
using Domain.Interfaces;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{

    public class EventStoreSQLContext : IDbContext
    {
        //public IConfiguration Configuration { get; }
        public EventStoreSQLContext(DbContextOptions options)
            : base(options)
        //: base(configuration.GetConnectionString("EventConnection"))
        {

        }

        public DbSet<StoredEvent> StoredEvent { get; set; }


        /// <summary>
        /// 重写自定义Map配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        //protected override void OnModelCreating(ModuleBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new StudentMap());

        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
