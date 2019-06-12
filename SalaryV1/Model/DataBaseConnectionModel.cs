namespace SalaryV1.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseConnectionModel : DbContext
    {
        public DataBaseConnectionModel()
            : base("name=DataBaseConnectionModel1")
        {
        }

        public virtual DbSet<delete_stasus> delete_stasus { get; set; }
        public virtual DbSet<executor> executor { get; set; }
        public virtual DbSet<factors> factors { get; set; }
        public virtual DbSet<grayd> grayd { get; set; }
        public virtual DbSet<kind_of_work> kind_of_work { get; set; }
        public virtual DbSet<manager> manager { get; set; }
        public virtual DbSet<status_task> status_task { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tasks> tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<delete_stasus>()
                .HasMany(e => e.tasks)
                .WithOptional(e => e.delete_stasus)
                .HasForeignKey(e => e.delete_status_id);

            modelBuilder.Entity<executor>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.executor)
                .HasForeignKey(e => e.executor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<factors>()
                .Property(e => e.analysis)
                .HasPrecision(10, 2);

            modelBuilder.Entity<factors>()
                .Property(e => e.deployment)
                .HasPrecision(10, 2);

            modelBuilder.Entity<factors>()
                .Property(e => e.support)
                .HasPrecision(10, 2);

            modelBuilder.Entity<factors>()
                .Property(e => e.time_factor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<factors>()
                .Property(e => e.hard_factor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<factors>()
                .Property(e => e.money_factor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<grayd>()
                .HasMany(e => e.executor)
                .WithRequired(e => e.grayd)
                .HasForeignKey(e => e.grayd_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<kind_of_work>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.kind_of_work)
                .HasForeignKey(e => e.kind_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manager>()
                .HasMany(e => e.executor)
                .WithRequired(e => e.manager)
                .HasForeignKey(e => e.manager_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manager>()
                .HasOptional(e => e.factors)
                .WithRequired(e => e.manager);

            modelBuilder.Entity<status_task>()
                .HasMany(e => e.tasks)
                .WithRequired(e => e.status_task)
                .HasForeignKey(e => e.status_id)
                .WillCascadeOnDelete(false);
        }
    }
}
