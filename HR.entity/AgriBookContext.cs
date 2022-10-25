using System;
using HR.entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HR.entity
{
    public partial class AgriBookContext : DbContext
    {
        public AgriBookContext()
        {
        }

        public AgriBookContext(DbContextOptions<AgriBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcademicQualification> AcademicQualifications { get; set; }
        public virtual DbSet<AdministrativeDepartment> AdministrativeDepartments { get; set; }
        public virtual DbSet<AdministrativeDepartmentJob> AdministrativeDepartmentJobs { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<AuthorityJob> AuthorityJobs { get; set; }
        public virtual DbSet<CareerProgression> CareerProgressions { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Center> Centers { get; set; }
        public virtual DbSet<CenterJob> CenterJobs { get; set; }
        public virtual DbSet<ContractType> ContractTypes { get; set; }
        public virtual DbSet<DecreeType> DecreeTypes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentJob> DepartmentJobs { get; set; }
        public virtual DbSet<Directorate> Directorates { get; set; }
        public virtual DbSet<DirectorateJob> DirectorateJobs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeLeaveApplication> EmployeeLeaveApplications { get; set; }
        public virtual DbSet<EmployeeLeaveBalance> EmployeeLeaveBalances { get; set; }
        public virtual DbSet<EmployementDetail> EmployementDetails { get; set; }
        public virtual DbSet<EmployementStatus> EmployementStatuses { get; set; }
        public virtual DbSet<Extension> Extensions { get; set; }
        public virtual DbSet<ExtensionCenter> ExtensionCenters { get; set; }
        public virtual DbSet<ExtensionCenterJob> ExtensionCenterJobs { get; set; }
        public virtual DbSet<ExtensionSection> ExtensionSections { get; set; }
        public virtual DbSet<ExtensionSectionDetail> ExtensionSectionDetails { get; set; }
        public virtual DbSet<ExtensionSectionJob> ExtensionSectionJobs { get; set; }
        public virtual DbSet<FamilyDetail> FamilyDetails { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<LeaveTypeDay> LeaveTypeDays { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public virtual DbSet<RelativeType> RelativeTypes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionJob> SectionJobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=AgriBook;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AcademicQualification>(entity =>
            {
                entity.HasKey(e => e.PkacademicQualificationId);

                entity.ToTable("AcademicQualification");

                entity.Property(e => e.PkacademicQualificationId).HasColumnName("PKAcademicQualificationID");

                entity.Property(e => e.AcademicQualificationType).HasMaxLength(50);
            });

            modelBuilder.Entity<AdministrativeDepartment>(entity =>
            {
                entity.HasKey(e => e.PkadministrativeDepartmentId);

                entity.ToTable("AdministrativeDepartment");

                entity.Property(e => e.PkadministrativeDepartmentId).HasColumnName("PKAdministrativeDepartmentID");

                entity.Property(e => e.AdministrativeDepartmentNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("AdministrativeDepartmentNameAR");

                entity.Property(e => e.AdministrativeDepartmentNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("AdministrativeDepartmentNameEN");

                entity.Property(e => e.FkdirectorateId).HasColumnName("FKDirectorateID");

                entity.HasOne(d => d.Fkdirectorate)
                    .WithMany(p => p.AdministrativeDepartments)
                    .HasForeignKey(d => d.FkdirectorateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdministrativeDepartment_Directorate");
            });

            modelBuilder.Entity<AdministrativeDepartmentJob>(entity =>
            {
                entity.HasKey(e => e.PkadministrativeDepartmentJobId);

                entity.ToTable("AdministrativeDepartmentJob");

                entity.Property(e => e.PkadministrativeDepartmentJobId).HasColumnName("PKAdministrativeDepartmentJobID");

                entity.Property(e => e.FkadministrativeDepartmentId).HasColumnName("FKAdministrativeDepartmentID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.FkadministrativeDepartment)
                    .WithMany(p => p.AdministrativeDepartmentJobs)
                    .HasForeignKey(d => d.FkadministrativeDepartmentId)
                    .HasConstraintName("FK_AdministrativeDepartmentJob_AdministrativeDepartment");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.AdministrativeDepartmentJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .HasConstraintName("FK_AdministrativeDepartmentJob_Job");
            });

            modelBuilder.Entity<Authority>(entity =>
            {
                entity.HasKey(e => e.PkauthorityId);

                entity.ToTable("Authority");

                entity.Property(e => e.PkauthorityId).HasColumnName("PKAuthorityID");

                entity.Property(e => e.AuthorityNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("AuthorityNameAR");

                entity.Property(e => e.AuthorityNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("AuthorityNameEN");

                entity.Property(e => e.FkdirectorateId).HasColumnName("FKDirectorateID");

                entity.HasOne(d => d.Fkdirectorate)
                    .WithMany(p => p.Authorities)
                    .HasForeignKey(d => d.FkdirectorateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authority_Directorate");
            });

            modelBuilder.Entity<AuthorityJob>(entity =>
            {
                entity.HasKey(e => e.PkauthorityJobId);

                entity.ToTable("AuthorityJob");

                entity.Property(e => e.PkauthorityJobId).HasColumnName("PKAuthorityJobID");

                entity.Property(e => e.FkauthotityId).HasColumnName("FKAuthotityID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.Fkauthotity)
                    .WithMany(p => p.AuthorityJobs)
                    .HasForeignKey(d => d.FkauthotityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorityJob_Authority");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.AuthorityJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorityJob_Job");
            });

            modelBuilder.Entity<CareerProgression>(entity =>
            {
                entity.HasKey(e => e.PkcareerProgressionId);

                entity.ToTable("CareerProgression");

                entity.Property(e => e.PkcareerProgressionId).HasColumnName("PKCareerProgressionID");

                entity.Property(e => e.CareerProgressionDate).HasColumnType("date");

                entity.Property(e => e.CareerProgressionRaise).HasColumnType("money");

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeID");

                entity.HasOne(d => d.Fkemployee)
                    .WithMany(p => p.CareerProgressions)
                    .HasForeignKey(d => d.FkemployeeId)
                    .HasConstraintName("FK_CareerProgression_Employee");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.PkcategoryId);

                entity.ToTable("Category");

                entity.Property(e => e.PkcategoryId).HasColumnName("PKCategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Center>(entity =>
            {
                entity.HasKey(e => e.PkcenterId);

                entity.ToTable("Center");

                entity.Property(e => e.PkcenterId).HasColumnName("PKCenterID");

                entity.Property(e => e.CenterNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("CenterNameAR");

                entity.Property(e => e.CenterNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("CenterNameEN");

                entity.Property(e => e.FksectionId).HasColumnName("FKSectionID");

                entity.HasOne(d => d.Fksection)
                    .WithMany(p => p.Centers)
                    .HasForeignKey(d => d.FksectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Center_Section");
            });

            modelBuilder.Entity<CenterJob>(entity =>
            {
                entity.HasKey(e => e.PkcenterJobId);

                entity.ToTable("CenterJob");

                entity.Property(e => e.PkcenterJobId).HasColumnName("PKCenterJobID");

                entity.Property(e => e.FkcenterId).HasColumnName("FKCenterID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.Fkcenter)
                    .WithMany(p => p.CenterJobs)
                    .HasForeignKey(d => d.FkcenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterJob_Center");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.CenterJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterJob_Job");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.HasKey(e => e.PkcontractType);

                entity.ToTable("ContractType");

                entity.Property(e => e.PkcontractType).HasColumnName("PKContractType");

                entity.Property(e => e.ContractTypeName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DecreeType>(entity =>
            {
                entity.HasKey(e => e.PkdecreeTypeId);

                entity.ToTable("DecreeType");

                entity.Property(e => e.PkdecreeTypeId).HasColumnName("PKDecreeTypeID");

                entity.Property(e => e.DecreeTypeName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.PkdepartmentId);

                entity.ToTable("Department");

                entity.Property(e => e.PkdepartmentId).HasColumnName("PKDepartmentID");

                entity.Property(e => e.DepartmentNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentNameAR");

                entity.Property(e => e.DepartmentNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentNameEN");

                entity.Property(e => e.FkauthotiryId).HasColumnName("FKAuthotiryID");

                entity.HasOne(d => d.Fkauthotiry)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.FkauthotiryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Authority");
            });

            modelBuilder.Entity<DepartmentJob>(entity =>
            {
                entity.HasKey(e => e.PkdepartmentJobId);

                entity.ToTable("DepartmentJob");

                entity.Property(e => e.PkdepartmentJobId).HasColumnName("PKDepartmentJobID");

                entity.Property(e => e.FkdepartmentId).HasColumnName("FKDepartmentID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.Fkdepartment)
                    .WithMany(p => p.DepartmentJobs)
                    .HasForeignKey(d => d.FkdepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentJob_Department");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.DepartmentJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentJob_Job");
            });

            modelBuilder.Entity<Directorate>(entity =>
            {
                entity.HasKey(e => e.PkdirectorateId);

                entity.ToTable("Directorate");

                entity.Property(e => e.PkdirectorateId).HasColumnName("PKDirectorateID");

                entity.Property(e => e.DirectorateNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("DirectorateNameAR");

                entity.Property(e => e.DirectorateNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("DirectorateNameEN");
            });

            modelBuilder.Entity<DirectorateJob>(entity =>
            {
                entity.HasKey(e => e.PkdirectorateJobId);

                entity.ToTable("DirectorateJob");

                entity.Property(e => e.PkdirectorateJobId).HasColumnName("PKDirectorateJobID");

                entity.Property(e => e.FkdirectorateId).HasColumnName("FKDirectorateID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.Fkdirectorate)
                    .WithMany(p => p.DirectorateJobs)
                    .HasForeignKey(d => d.FkdirectorateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectorateJob_Directorate");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.DirectorateJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectorateJob_Job");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.PkemployeeId);

                entity.ToTable("Employee");

                entity.Property(e => e.PkemployeeId).HasColumnName("PKEmployeeID");

                entity.Property(e => e.EmployeeDateOfBirth).HasColumnType("date");

                entity.Property(e => e.EmployeeFinancialNumber)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeFirstName).HasMaxLength(50);

                entity.Property(e => e.EmployeeImageUrl)
                    .HasMaxLength(100)
                    .HasColumnName("EmployeeImageURL");

                entity.Property(e => e.EmployeeLastName).HasMaxLength(50);

                entity.Property(e => e.EmployeeMiddleName).HasMaxLength(50);

                entity.Property(e => e.EmployeePhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength(true);


                entity.Property(e => e.FkacademicQualificationId).HasColumnName("FKAcademicQualificationID");

                entity.Property(e => e.FkmaritalStatusId).HasColumnName("FKMaritalStatusID");

                entity.HasOne(d => d.FkacademicQualification)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkacademicQualificationId)
                    .HasConstraintName("FK_Employee_AcademicQualification");

                entity.HasOne(d => d.FkmaritalStatus)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FkmaritalStatusId)
                    .HasConstraintName("FK_Employee_MaritalStatus");
            });

            modelBuilder.Entity<EmployeeLeaveApplication>(entity =>
            {
                entity.HasKey(e => e.PkemployeeLeaveApplicationId);

                entity.ToTable("EmployeeLeaveApplication");

                entity.Property(e => e.PkemployeeLeaveApplicationId).HasColumnName("PKEmployeeLeaveApplicationID");

                entity.Property(e => e.EmployeeLeaveApplicationDaysCount).HasComputedColumnSql("(datediff(day,[EmployeeLeaveApplicationToDate],[EmployeeLeaveApplicationFromDate]))", false);

                entity.Property(e => e.EmployeeLeaveApplicationFromDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeLeaveApplicationToDate).HasColumnType("datetime");

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeID");

                entity.Property(e => e.FkleaveTypeId).HasColumnName("FKLeaveTypeID");

                entity.HasOne(d => d.Fkemployee)
                    .WithMany(p => p.EmployeeLeaveApplications)
                    .HasForeignKey(d => d.FkemployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaveApplication_Employee");

                entity.HasOne(d => d.FkleaveType)
                    .WithMany(p => p.EmployeeLeaveApplications)
                    .HasForeignKey(d => d.FkleaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaveApplication_LeaveType");
            });

            modelBuilder.Entity<EmployeeLeaveBalance>(entity =>
            {
                entity.HasKey(e => e.PkemployeeLeaveBalanceId);

                entity.ToTable("EmployeeLeaveBalance");

                entity.Property(e => e.PkemployeeLeaveBalanceId).HasColumnName("PKEmployeeLeaveBalanceID");

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeID");
            });

            modelBuilder.Entity<EmployementDetail>(entity =>
            {
                entity.HasKey(e => e.PkemployementDetailsId);

                entity.Property(e => e.PkemployementDetailsId).HasColumnName("PKEmployementDetailsID");

                entity.Property(e => e.EmployementDecreeDate).HasColumnType("date");

                entity.Property(e => e.EmployementRetirementDate).HasColumnType("date");

                entity.Property(e => e.EmployementStartWorkingDate).HasColumnType("date");

                entity.Property(e => e.FkcategoryId).HasColumnName("FKCategoryID");

                entity.Property(e => e.FkcontractType).HasColumnName("FKContractType");

                entity.Property(e => e.FkdecreeType).HasColumnName("FKDecreeType");

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeID");

                entity.Property(e => e.FkemploymentStatusId).HasColumnName("FKEmploymentStatusID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.Fkcategory)
                    .WithMany(p => p.EmployementDetails)
                    .HasForeignKey(d => d.FkcategoryId)
                    .HasConstraintName("FK_EmployementDetails_Category");

                entity.HasOne(d => d.FkcontractTypeNavigation)
                    .WithMany(p => p.EmployementDetails)
                    .HasForeignKey(d => d.FkcontractType)
                    .HasConstraintName("FK_EmployementDetails_ContractType");

                entity.HasOne(d => d.FkdecreeTypeNavigation)
                    .WithMany(p => p.EmployementDetails)
                    .HasForeignKey(d => d.FkdecreeType)
                    .HasConstraintName("FK_EmployementDetails_DecreeType");

                entity.HasOne(d => d.Fkemployee)
                    .WithMany(p => p.EmployementDetails)
                    .HasForeignKey(d => d.FkemployeeId)
                    .HasConstraintName("FK_EmployementDetails_Employee1");

                entity.HasOne(d => d.FkemploymentStatus)
                    .WithMany(p => p.EmployementDetails)
                    .HasForeignKey(d => d.FkemploymentStatusId)
                    .HasConstraintName("FK_EmployementDetails_EmployementStatus");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.EmployementDetails)
                    .HasForeignKey(d => d.FkjobId)
                    .HasConstraintName("FK_EmployementDetails_Job");
            });

            modelBuilder.Entity<EmployementStatus>(entity =>
            {
                entity.HasKey(e => e.PkemploymentStatusId);

                entity.ToTable("EmployementStatus");

                entity.Property(e => e.PkemploymentStatusId).HasColumnName("PKEmploymentStatusID");

                entity.Property(e => e.EmploymentStatusName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Extension>(entity =>
            {
                entity.HasKey(e => e.PkextensionId)
                    .HasName("PK_ExtensionService");

                entity.ToTable("Extension");

                entity.Property(e => e.PkextensionId).HasColumnName("PKExtensionID");

                entity.Property(e => e.ExtensionNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("ExtensionNameAR");

                entity.Property(e => e.ExtensionNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("ExtensionNameEN");
            });

            modelBuilder.Entity<ExtensionCenter>(entity =>
            {
                entity.HasKey(e => e.PkextensionCenterId);

                entity.ToTable("ExtensionCenter");

                entity.Property(e => e.PkextensionCenterId).HasColumnName("PKExtensionCenterID");

                entity.Property(e => e.ExtensionCenterNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("ExtensionCenterNameAR");

                entity.Property(e => e.ExtensionCenterNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("ExtensionCenterNameEN");

                entity.Property(e => e.FkextensionId).HasColumnName("FKExtensionID");

                entity.HasOne(d => d.Fkextension)
                    .WithMany(p => p.ExtensionCenters)
                    .HasForeignKey(d => d.FkextensionId)
                    .HasConstraintName("FK_ExtensionCenter_Extension");
            });

            modelBuilder.Entity<ExtensionCenterJob>(entity =>
            {
                entity.HasKey(e => e.PkextensionCenterJobId);

                entity.ToTable("ExtensionCenterJob");

                entity.Property(e => e.PkextensionCenterJobId).HasColumnName("PKExtensionCenterJobID");

                entity.Property(e => e.FkextensionCenterId).HasColumnName("FKExtensionCenterID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.FkextensionCenter)
                    .WithMany(p => p.ExtensionCenterJobs)
                    .HasForeignKey(d => d.FkextensionCenterId)
                    .HasConstraintName("FK_ExtensionCenterJob_ExtensionCenter");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.ExtensionCenterJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .HasConstraintName("FK_ExtensionCenterJob_Job");
            });

            modelBuilder.Entity<ExtensionSection>(entity =>
            {
                entity.HasKey(e => e.PkextensionSectionId);

                entity.ToTable("ExtensionSection");

                entity.Property(e => e.PkextensionSectionId).HasColumnName("PKExtensionSectionID");

                entity.Property(e => e.ExtensionSectionName).HasMaxLength(50);
            });

            modelBuilder.Entity<ExtensionSectionDetail>(entity =>
            {
                entity.HasKey(e => e.PkextensionSectionDetailsId);

                entity.Property(e => e.PkextensionSectionDetailsId).HasColumnName("PKExtensionSectionDetailsID");

                entity.Property(e => e.FkextensionId).HasColumnName("FKExtensionID");

                entity.Property(e => e.FkextensionSectionId).HasColumnName("FKExtensionSectionID");

                entity.HasOne(d => d.Fkextension)
                    .WithMany(p => p.ExtensionSectionDetails)
                    .HasForeignKey(d => d.FkextensionId)
                    .HasConstraintName("FK_ExtensionSectionDetails_Extension");

                entity.HasOne(d => d.FkextensionSection)
                    .WithMany(p => p.ExtensionSectionDetails)
                    .HasForeignKey(d => d.FkextensionSectionId)
                    .HasConstraintName("FK_ExtensionSectionDetails_ExtensionSection");
            });

            modelBuilder.Entity<ExtensionSectionJob>(entity =>
            {
                entity.HasKey(e => e.PkextensionSectionJobId);

                entity.ToTable("ExtensionSectionJob");

                entity.Property(e => e.PkextensionSectionJobId).HasColumnName("PKExtensionSectionJobID");

                entity.Property(e => e.FkextensionSectionId).HasColumnName("FKExtensionSectionID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.HasOne(d => d.FkextensionSection)
                    .WithMany(p => p.ExtensionSectionJobs)
                    .HasForeignKey(d => d.FkextensionSectionId)
                    .HasConstraintName("FK_ExtensionSectionJob_ExtensionSection");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.ExtensionSectionJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .HasConstraintName("FK_ExtensionSectionJob_Job");
            });

            modelBuilder.Entity<FamilyDetail>(entity =>
            {
                entity.HasKey(e => e.PkfamilyDetailsId);

                entity.Property(e => e.PkfamilyDetailsId).HasColumnName("PKFamilyDetailsID");

                entity.Property(e => e.FamilyDetailsDob)
                    .HasColumnType("date")
                    .HasColumnName("FamilyDetailsDOB");

                entity.Property(e => e.FamilyDetailsFullName).HasMaxLength(50);

                entity.Property(e => e.FamilyDetailsGender)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FkemployeeId).HasColumnName("FKEmployeeID");

                entity.Property(e => e.FkrelativeTypeId).HasColumnName("FKRelativeTypeID");

                entity.HasOne(d => d.Fkemployee)
                    .WithMany(p => p.FamilyDetails)
                    .HasForeignKey(d => d.FkemployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyDetails_Employee");

                entity.HasOne(d => d.FkrelativeType)
                    .WithMany(p => p.FamilyDetails)
                    .HasForeignKey(d => d.FkrelativeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FamilyDetails_RelativeType");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.PkjobId);

                entity.ToTable("Job");

                entity.Property(e => e.PkjobId).HasColumnName("PKJobID");

                entity.Property(e => e.FkcategoryId).HasColumnName("FKCategoryID");

                entity.Property(e => e.JobName).HasMaxLength(50);

                entity.HasOne(d => d.Fkcategory)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.FkcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_Category");
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.HasKey(e => e.PkleaveTypeId);

                entity.ToTable("LeaveType");

                entity.Property(e => e.PkleaveTypeId).HasColumnName("PKLeaveTypeID");

                entity.Property(e => e.LeaveTypeNameAr)
                    .HasMaxLength(10)
                    .HasColumnName("LeaveTypeNameAR")
                    .IsFixedLength(true);

                entity.Property(e => e.LeaveTypeNameEn)
                    .HasMaxLength(10)
                    .HasColumnName("LeaveTypeNameEN")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LeaveTypeDay>(entity =>
            {
                entity.HasKey(e => e.PkleaveTypeDaysId);

                entity.Property(e => e.PkleaveTypeDaysId).HasColumnName("PKLeaveTypeDaysID");

                entity.Property(e => e.FkcontractTypeId).HasColumnName("FKContractTypeID");

                entity.Property(e => e.FkleaveTypeId).HasColumnName("FKLeaveTypeID");

                entity.HasOne(d => d.FkcontractType)
                    .WithMany(p => p.LeaveTypeDays)
                    .HasForeignKey(d => d.FkcontractTypeId)
                    .HasConstraintName("FK_LeaveTypeDays_ContractType");

                entity.HasOne(d => d.FkleaveType)
                    .WithMany(p => p.LeaveTypeDays)
                    .HasForeignKey(d => d.FkleaveTypeId)
                    .HasConstraintName("FK_LeaveTypeDays_LeaveType");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.HasKey(e => e.PkmaritalStatusId);

                entity.ToTable("MaritalStatus");

                entity.Property(e => e.PkmaritalStatusId).HasColumnName("PKMaritalStatusID");

                entity.Property(e => e.MaritalStatusType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RelativeType>(entity =>
            {
                entity.HasKey(e => e.PkrelativeTypeId);

                entity.ToTable("RelativeType");

                entity.Property(e => e.PkrelativeTypeId).HasColumnName("PKRelativeTypeID");

                entity.Property(e => e.RelativeTypeName)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => e.PksectionId);

                entity.ToTable("Section");

                entity.Property(e => e.PksectionId).HasColumnName("PKSectionID");

                entity.Property(e => e.FkdepartmentId).HasColumnName("FKDepartmentID");

                entity.Property(e => e.SectionNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("SectionNameAR");

                entity.Property(e => e.SectionNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("SectionNameEN");

                entity.HasOne(d => d.Fkdepartment)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.FkdepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Section_Department");
            });

            modelBuilder.Entity<SectionJob>(entity =>
            {
                entity.HasKey(e => e.PksectionJobId);

                entity.ToTable("SectionJob");

                entity.Property(e => e.PksectionJobId).HasColumnName("PKSectionJobID");

                entity.Property(e => e.FkjobId).HasColumnName("FKJobID");

                entity.Property(e => e.FksectionId).HasColumnName("FKSectionID");

                entity.HasOne(d => d.Fkjob)
                    .WithMany(p => p.SectionJobs)
                    .HasForeignKey(d => d.FkjobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionJob_Job");

                entity.HasOne(d => d.Fksection)
                    .WithMany(p => p.SectionJobs)
                    .HasForeignKey(d => d.FksectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionJob_Section");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
