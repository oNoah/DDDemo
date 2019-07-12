using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Context
{
    public class StudyContext : IDbContext
    {
        //public IConfiguration Configuration { get; }
        public StudyContext(DbContextOptions options)
            : base(options)
        {

        }
        //public StudyContext(string connection)
        //    : base(connection)
        //{

        //}

        public DbSet<Student> Student { get; set; }


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
            modelBuilder.ApplyConfiguration(new StudentMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
