#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GarageAzureDeployements.Models;

namespace GarageAzureDeployements.Data
{
    public class GarageAzureDeployementsContext : DbContext
    {
        public GarageAzureDeployementsContext (DbContextOptions<GarageAzureDeployementsContext> options)
            : base(options)
        {

        }
        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            //modelBuilder.Entity<Vehicle>(entity =>
            //modelBuilder.Entity<Vehicle>.HasData()
        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
