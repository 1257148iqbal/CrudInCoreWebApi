using Microsoft.EntityFrameworkCore; //For This Namespace Install: Install-package Microsoft.EntityFrameworkCore
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudInCoreWebApi.Models
{
    public class CrudInCoreWebApiContext: DbContext
    {
        public CrudInCoreWebApiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>().HasData(
                new Trainee
                {
                    TraineeID=1,
                    Name="ALI",
                    DateOfBirth= new DateTime(1994, 01, 25),
                    EmailID="ali@gmail.com",
                    Gender="Male",
                    Address="Dhaka", 
                    CellPhoneNo="01813148110"
                },


                new Trainee
                {
                    TraineeID = 2,
                    Name = "Harami",
                    DateOfBirth = new DateTime(1994, 01, 25),
                    EmailID = "harami@gmail.com",
                    Gender = "Female",
                    Address = "Ctg",
                    CellPhoneNo = "01813148110"
                },
                new Trainee
                {
                    TraineeID = 3,
                    Name = "Arefin",
                    DateOfBirth = new DateTime(1994, 01, 25),
                    EmailID = "arefin@gmail.com",
                    Gender = "Male",
                    Address = "Rohingga",
                    CellPhoneNo = "01815501137"
                }


                );
        }
    }
}
