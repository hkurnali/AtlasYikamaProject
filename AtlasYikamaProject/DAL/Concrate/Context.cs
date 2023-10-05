using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace AtlasYikamaProject.DAL.Concrate
{
    public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Comment> Comments { get; set; }
       
        public DbSet<Service> Services{ get; set; }

        public DbSet<AboutPage> AboutPages { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}