using Northwest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Northwest.DAL
{
    public class NorthwestContext : DbContext
    {
        public NorthwestContext() : base("NorthwestContext")
        {

        }

        public DbSet<Animal> Animal { get; set; }
        public DbSet<Assay> Assay { get; set; }
        public DbSet<AssayTest> AssayTest { get; set; }
        public DbSet<Compound> Compound { get; set; }
        public DbSet<CompoundAnimal> CompoundAnimal { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CustomerDiscounts> CustomerDiscounts { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeesTest> EmployeesTest { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<TestMaterials> TestMaterials { get; set; }
        public DbSet<Wage> Wage { get; set; }
        public DbSet<WageType> WageType { get; set; }
        public DbSet<ZipCode> ZipCode { get; set; }
    }
}