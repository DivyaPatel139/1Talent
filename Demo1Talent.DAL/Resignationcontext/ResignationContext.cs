using Demo1Talent.DTO.Domain_Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1Talent.DAL.Resignationcontext
{
    public class ResignationContext : DbContext
    {
        public ResignationContext(DbContextOptions<ResignationContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Resignation> Resignations { get; set; }
        
    }

}
