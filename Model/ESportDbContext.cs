using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESport.Model
{
    public class ESportContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=178.155.224.44; Initial Catalog=ESport; User ID = sa; Password = 2021Sommer");
            //options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ESport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Info> Infos { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
    }
}
