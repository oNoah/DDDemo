using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure.Data
{
    public class StudyContextFactory : IDesignTimeDbContextFactory<StudyContext>
    {
        public StudyContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder();
            var connection = ConfigHelper.GetConfig().GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connection);
            return new StudyContext(builder.Options);
        }
    }
    public class EventStoreSQLContextFactory : IDesignTimeDbContextFactory<EventStoreSQLContext>
    {
        public EventStoreSQLContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder();
            var connection = ConfigHelper.GetConfig().GetConnectionString("EventConnection");
            builder.UseSqlServer(connection);
            return new EventStoreSQLContext(builder.Options);
        }
    }

    public static class ConfigHelper
    {
        public static IConfigurationRoot configuration;
        public static IConfigurationRoot GetConfig()
        {
            if (configuration == null)
            {
                configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
            }
            return configuration;
        }
    }

}
