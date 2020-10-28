using FakeXieChengAsp.netCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXieChengAsp.netCore.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 
         
        }
       public DbSet<TouristRoute> TouristRoutes { get; set; }
       public DbSet<TouristRoutePictures> TouristRoutePictures { get; set; }
    }
}
