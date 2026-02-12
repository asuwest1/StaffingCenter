using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SharedClasses.Models
{
    public partial class StaffingCenterSENGSContext : DbContext
    {
        public StaffingCenterSENGSContext()
        {
        }

        public StaffingCenterSENGSContext(DbContextOptions<StaffingCenterSENGSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actual> Actuals { get; set; }
        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<AllocationProject> AllocationProjects { get; set; }
        public virtual DbSet<CustomRatio> CustomRatios { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Demand> Demands { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeRolAllocationProject> EmployeeRolAllocationProjects { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<FundingType> FundingTypes { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<LogUser> LogUsers { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillToEmployee> SkillToEmployees { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<WorkCenter> WorkCenters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SRNACHH19\\MSSQL;Initial Catalog=StaffingCenterSENGSDev;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Actual>(entity =>
            {
                entity.ToTable("Actual");

                entity.Property(e => e.Acct).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.FkEmployeeNavigation)
                    .WithMany(p => p.Actuals)
                    .HasForeignKey(d => d.FkEmployee)
                    .HasConstraintName("FK_Actual_Employee");

                entity.HasOne(d => d.FkProjectAllocationNavigation)
                    .WithMany(p => p.Actuals)
                    .HasForeignKey(d => d.FkProjectAllocation)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Actual_AllocationProject");

                entity.HasOne(d => d.FkWorkCenterNavigation)
                    .WithMany(p => p.Actuals)
                    .HasForeignKey(d => d.FkWorkCenter)
                    .HasConstraintName("FK_Actual_WorkCenter");
            });

            modelBuilder.Entity<Allocation>(entity =>
            {
                entity.ToTable("Allocation");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.FkEmployeeNavigation)
                    .WithMany(p => p.Allocations)
                    .HasForeignKey(d => d.FkEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Allocation_Employee");

                entity.HasOne(d => d.FkProjectNavigation)
                    .WithMany(p => p.Allocations)
                    .HasForeignKey(d => d.FkProject)
                    .HasConstraintName("FK_Allocation_AllocationProject");

                entity.HasOne(d => d.FkWorkCenterNavigation)
                    .WithMany(p => p.Allocations)
                    .HasForeignKey(d => d.FkWorkCenter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Allocation_WorkCenter");
            });

            modelBuilder.Entity<AllocationProject>(entity =>
            {
                entity.ToTable("AllocationProject");

                entity.HasIndex(e => e.Network, "Idx_Network")
                    .IsUnique()
                    .HasFilter("([Network] IS NOT NULL)");

                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectDescription).IsUnicode(false);

                entity.Property(e => e.ProjectName).IsUnicode(false);

                entity.HasOne(d => d.FkCustomerNavigation)
                    .WithMany(p => p.AllocationProjects)
                    .HasForeignKey(d => d.FkCustomer)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_AllocationProject_Customer");

                entity.HasOne(d => d.FkFundingTypeNavigation)
                    .WithMany(p => p.AllocationProjects)
                    .HasForeignKey(d => d.FkFundingType)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_AllocationProject_FundingType");
            });

            modelBuilder.Entity<CustomRatio>(entity =>
            {
                entity.ToTable("CustomRatio");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ft).HasColumnName("FT");

                entity.Property(e => e.Gt).HasColumnName("GT");

                entity.HasOne(d => d.FkEmployeeNavigation)
                    .WithMany(p => p.CustomRatios)
                    .HasForeignKey(d => d.FkEmployee)
                    .HasConstraintName("FK_CustomRatio_Employee");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Demand>(entity =>
            {
                entity.ToTable("Demand");

                entity.Property(e => e.ActivityName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Etcfte).HasColumnName("ETCFTE");

                entity.Property(e => e.Etchours).HasColumnName("ETCHours");

                entity.Property(e => e.ForecastFinish).HasColumnType("date");

                entity.Property(e => e.ForecastStart).HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RespEngr)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.FkAllocationProjectNavigation)
                    .WithMany(p => p.Demands)
                    .HasForeignKey(d => d.FkAllocationProject)
                    .HasConstraintName("FK_Demand_AllocationProject");

                entity.HasOne(d => d.FkWorkCenterNavigation)
                    .WithMany(p => p.Demands)
                    .HasForeignKey(d => d.FkWorkCenter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Demand_WorkCenter");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.OrgCode).IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TaleoReq).IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.FkEmployeeTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkEmployeeType)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Employee_EmployeeType");

                entity.HasOne(d => d.FkWorkCenterNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkWorkCenter)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Employee_WorkCenter");
            });

            modelBuilder.Entity<EmployeeRolAllocationProject>(entity =>
            {
                entity.ToTable("EmployeeRol_AllocationProject");

                entity.HasOne(d => d.FkAllocationProjectNavigation)
                    .WithMany(p => p.EmployeeRolAllocationProjects)
                    .HasForeignKey(d => d.FkAllocationProject)
                    .HasConstraintName("FK_EmployeeRol_AllocationProject_AllocationProject");

                entity.HasOne(d => d.FkEmployeeNavigation)
                    .WithMany(p => p.EmployeeRolAllocationProjects)
                    .HasForeignKey(d => d.FkEmployee)
                    .HasConstraintName("FK_EmployeeRol_AllocationProject_Employee");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EmployeeType");

                entity.HasIndex(e => e.Name, "IX_EmployeeType")
                    .IsUnique();

                entity.Property(e => e.Fte).HasColumnName("FTE");

                entity.Property(e => e.Gt).HasColumnName("GT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FundingType>(entity =>
            {
                entity.ToTable("FundingType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holiday");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogUser>(entity =>
            {
                entity.ToTable("LogUser");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.IsEm).HasColumnName("IsEM");

                entity.Property(e => e.IsPm).HasColumnName("IsPM");

                entity.Property(e => e.IsPoc).HasColumnName("IsPOC");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.HasIndex(e => e.Name, "IX_Skill")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkillToEmployee>(entity =>
            {
                entity.ToTable("SkillToEmployee");

                entity.HasOne(d => d.FkEmployeeNavigation)
                    .WithMany(p => p.SkillToEmployees)
                    .HasForeignKey(d => d.FkEmployee)
                    .HasConstraintName("FK_SkillToEmployee_Employee");

                entity.HasOne(d => d.FkSkillNavigation)
                    .WithMany(p => p.SkillToEmployees)
                    .HasForeignKey(d => d.FkSkill)
                    .HasConstraintName("FK_SkillToEmployee_Skill");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.MicrosoftAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.HasOne(d => d.FkRoleNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.FkRole)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.FkUser)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<WorkCenter>(entity =>
            {
                entity.ToTable("WorkCenter");

                entity.HasIndex(e => e.Name, "IX_WorkCenter")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
