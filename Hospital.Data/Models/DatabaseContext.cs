namespace Hospital.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseContext : DbContext
    {
        // Your context has been configured to use a 'DatabaseContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hospital.Data.Models.DatabaseContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DatabaseContext' 
        // connection string in the application configuration file.
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePatientDepartment> EmployeePatientDepartments { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<MeasurementType> MeasurementTypes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Thesis> Thesises { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}