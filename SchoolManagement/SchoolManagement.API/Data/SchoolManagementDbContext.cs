using Microsoft.EntityFrameworkCore;
using SchoolManagement.API.Models.Domain;

namespace SchoolManagement.API.Data
{
    public class SchoolManagementDbContext:DbContext
    {
        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> dbContext):base(dbContext)
        {
            

        }
        public DbSet<Students> Students { get; set; }
        public DbSet<DriverDetails> DriverDetails { get; set; }
        public DbSet<StudentTransport> StudentTransport{ get; set; }
        public DbSet<StudentFeesDetails> StudentFeesDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentFeesDetails>().HasNoKey();
            modelBuilder.Entity<StudentTransport>().HasNoKey();

            //var students = new List<Students>
            //{
            //    new Students
            //    {
            //        Id= 1,
            //        Name="Aravind",
            //        Age=10,
            //        DOB=DateTime.Today,
            //        Class=5,
            //        MobileNo=12345678,
            //        DriverId=1
            //    },
            //    new Students
            //    {
            //        Id= 2,
            //        Name="Mourya",
            //        Age=8,
            //        DOB=DateTime.Today,
            //        Class=2,
            //        MobileNo=09876678,
            //        DriverId=2
            //    },
            //    new Students
            //    {
            //        Id= 3,
            //        Name="Chai",
            //        Age=9,
            //        DOB=DateTime.Today,
            //        Class=3,
            //        MobileNo=167895678,
            //        DriverId=3
            //    }
            //};
            //modelBuilder.Entity<Students>().HasData(students);

            //var drivers = new List<DriverDetails>
            //{ 
            //    new DriverDetails
            //    {
            //        Id=1,
            //        Name="Naveen",
            //        VehicleNo="AP012HJ1234",
            //        DriverMobileNo=09876543
            //    },
            //    new DriverDetails
            //    {
            //        Id=2,
            //        Name="Manoj",
            //        VehicleNo="AP01HL6383",
            //        DriverMobileNo=1234567
            //    },
            //    new DriverDetails
            //    {
            //        Id=3,
            //        Name="Kevin",
            //        VehicleNo="AP04HU1234",
            //        DriverMobileNo=345678
            //    }

            //};

            //modelBuilder.Entity<DriverDetails>().HasData(drivers);

            //var feesTerms = new List<FeeTerms>
            //{
            //    new FeeTerms
            //    {
            //        Id= 1,
            //        AmountToBe=5000,
            //        DueDate=DateTime.Today
            //    },
            //    new FeeTerms
            //    {
            //        Id= 2,
            //        AmountToBe=10000,
            //        DueDate=DateTime.Today
            //    },
            //    new FeeTerms
            //    {
            //        Id= 3,
            //        AmountToBe=15000,
            //        DueDate=DateTime.Today
            //    }
            //};

            //modelBuilder.Entity<FeeTerms>().HasData(feesTerms);

            //var studentFee = new List<StudentFeesDetails>
            //{
            //    new StudentFeesDetails
            //    {
            //        StudentId=1,
            //        FeeTermId=1,
            //        FeeTermAmount=5000,
            //        IsPaid=true
            //    },
            //    new StudentFeesDetails
            //    {
            //        StudentId=1,
            //        FeeTermId=2,
            //        FeeTermAmount=10000,
            //        IsPaid=true
            //    },
            //    new StudentFeesDetails
            //    {
            //        StudentId=2,
            //        FeeTermId=1,
            //        FeeTermAmount=5000,
            //        IsPaid=true
            //    },
            //    new StudentFeesDetails
            //    {
            //        StudentId=3,
            //        FeeTermId=1,
            //        FeeTermAmount=5000,
            //        IsPaid=true
            //    },new StudentFeesDetails
            //    {
            //        StudentId=3,
            //        FeeTermId=2,
            //        FeeTermAmount=5000,
            //        IsPaid=true
            //    }
            //};
            //modelBuilder.Entity<StudentFeesDetails>().HasData(studentFee);

            //var studentTrans = new List<StudentTransport>
            //{
            //    new StudentTransport
            //    {
            //        StudentId=1,
            //        PickUp="Bindunagar",
            //        Drop="Bindunagar"
            //    },
            //    new StudentTransport
            //    {
            //        StudentId=2,
            //        PickUp="Hindupur",
            //        Drop="Hindupur"
            //    },
            //    new StudentTransport
            //    {
            //        StudentId=1,
            //        PickUp="Somandepalli",
            //        Drop="Somandepalli"
            //    }
            //};
        }

    }
}
