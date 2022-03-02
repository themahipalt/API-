using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnAPIWithEFCore_CodeFirst_Demo2.Entities;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo2.DBAccess
{
    public class HappyDB228Context:DbContext
    {
        //define entity sets
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //Configure the ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4O1D65I\SQLEXPRESS;Initial Catalog=HappyDB228;Persist Security Info=True;User ID=sa;Password=pass@word1");
        }
    }
}
