using HumanResourceSystem.Model;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;


namespace HumanResourceSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<Collaborator> Collaborators { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collaborator>()
                .HasOne(b => b.Account)
                .WithOne(i => i.Collaborator)
                .HasForeignKey<Account>(b => b.CollaboratorId);
        }

        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<DayOff> DaysOff { get; set; }
        public virtual DbSet<Declaration> Declarations { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<ItemInUse> ItemsInUse { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
    }
}
