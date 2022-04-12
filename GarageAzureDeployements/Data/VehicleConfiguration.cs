using GarageAzureDeployements.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GarageAzureDeployements.Data
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData
            (
                new Vehicle 
                { 
                    Id = 1,
                    Brand = "Volvo",
                    NoOfWheels = 4,
                    Type = "Car"
                },
                 new Vehicle
                 {
                     Id = 2,
                     Brand = "Saab",
                     NoOfWheels = 4,
                     Type = "Car"
                 },
                  new Vehicle
                  {
                      Id = 1,
                      Brand = "Man",
                      NoOfWheels = 8,
                      Type = "Lorry"
                  }
            );

        }
    }
}
