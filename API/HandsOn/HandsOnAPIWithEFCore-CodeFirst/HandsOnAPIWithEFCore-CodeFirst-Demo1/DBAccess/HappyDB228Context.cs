using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnAPIWithEFCore_CodeFirst_Demo1.Entities;
namespace HandsOnAPIWithEFCore_CodeFirst_Demo1.DBAccess
{
    public class HappyDB228Context:DbContext
    {
        //Define entity sets
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAttendence> StudentAttendences { get; set; }
        //Configure the Connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4O1D65I\SQLEXPRESS;Initial Catalog=HappyDB228;Persist Security Info=True;User ID=sa;Password=pass@word1");
        }
    }
}
