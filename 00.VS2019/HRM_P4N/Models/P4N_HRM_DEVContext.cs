using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class P4N_HRM_DEVContext : DbContext
    {
        public P4N_HRM_DEVContext()
        {
        }

        public P4N_HRM_DEVContext(DbContextOptions<P4N_HRM_DEVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddresseList> AddresseLists { get; set; }
        public virtual DbSet<ApplicationForm> ApplicationForms { get; set; }
        public virtual DbSet<ArchcoPunch> ArchcoPunches { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchCompany> BranchCompanies { get; set; }
        public virtual DbSet<BuildVersion> BuildVersions { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyHistory> CompanyHistories { get; set; }
        public virtual DbSet<CompanyPaySeq> CompanyPaySeqs { get; set; }
        public virtual DbSet<CountryRegion> CountryRegions { get; set; }
        public virtual DbSet<DailyAttendance> DailyAttendances { get; set; }
        public virtual DbSet<DailyAttendanceLog> DailyAttendanceLogs { get; set; }
        public virtual DbSet<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentHistory> DepartmentHistories { get; set; }
        public virtual DbSet<EeList02142019> EeList02142019s { get; set; }
        public virtual DbSet<EffexGroupcompany> EffexGroupcompanies { get; set; }
        public virtual DbSet<EffexOrganization> EffexOrganizations { get; set; }
        public virtual DbSet<EmailList> EmailLists { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public virtual DbSet<EmployeeComment> EmployeeComments { get; set; }
        public virtual DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public virtual DbSet<EmployeeLeaf> EmployeeLeaves { get; set; }
        public virtual DbSet<EmployeePayrollHistory> EmployeePayrollHistories { get; set; }
        public virtual DbSet<EmployeePicture> EmployeePictures { get; set; }
        public virtual DbSet<EmployeeRefIdhistory> EmployeeRefIdhistories { get; set; }
        public virtual DbSet<EmployeeRelationshipList> EmployeeRelationshipLists { get; set; }
        public virtual DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual DbSet<EmployeeStaffingId> EmployeeStaffingIds { get; set; }
        public virtual DbSet<EmployeeStaffingIdhistory> EmployeeStaffingIdhistories { get; set; }
        public virtual DbSet<ExceptionType> ExceptionTypes { get; set; }
        public virtual DbSet<FeeList> FeeLists { get; set; }
        public virtual DbSet<GroupAuthList> GroupAuthLists { get; set; }
        public virtual DbSet<GroupCompany> GroupCompanies { get; set; }
        public virtual DbSet<GroupCompanyLocation> GroupCompanyLocations { get; set; }
        public virtual DbSet<GroupList> GroupLists { get; set; }
        public virtual DbSet<GroupUserList> GroupUserLists { get; set; }
        public virtual DbSet<HourSeq> HourSeqs { get; set; }
        public virtual DbSet<Idprefix> Idprefixes { get; set; }
        public virtual DbSet<ImageList> ImageLists { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InvoiceDiscrepancyReport> InvoiceDiscrepancyReports { get; set; }
        public virtual DbSet<InvoiceMaster> InvoiceMasters { get; set; }
        public virtual DbSet<LeavesOfAbsence> LeavesOfAbsences { get; set; }
        public virtual DbSet<LeavesOfTheYear> LeavesOfTheYears { get; set; }
        public virtual DbSet<LeavesOfTheYearAdded> LeavesOfTheYearAddeds { get; set; }
        public virtual DbSet<LeavesPolicy> LeavesPolicies { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationAddress> LocationAddresses { get; set; }
        public virtual DbSet<LogDailyAttendance> LogDailyAttendances { get; set; }
        public virtual DbSet<LogErrorCode> LogErrorCodes { get; set; }
        public virtual DbSet<LogFormUsage> LogFormUsages { get; set; }
        public virtual DbSet<LogTransactionError> LogTransactionErrors { get; set; }
        public virtual DbSet<MaritalStatusType> MaritalStatusTypes { get; set; }
        public virtual DbSet<MartitalStatusType> MartitalStatusTypes { get; set; }
        public virtual DbSet<Mboemployee> Mboemployees { get; set; }
        public virtual DbSet<MboemployeeHistory> MboemployeeHistories { get; set; }
        public virtual DbSet<Mbogroup> Mbogroups { get; set; }
        public virtual DbSet<MealMinuteSeq> MealMinuteSeqs { get; set; }
        public virtual DbSet<MenuAuthList> MenuAuthLists { get; set; }
        public virtual DbSet<MenuList> MenuLists { get; set; }
        public virtual DbSet<MinWage> MinWages { get; set; }
        public virtual DbSet<MinuteSeq> MinuteSeqs { get; set; }
        public virtual DbSet<MultipleBranchsAuthListInsteadGroupId> MultipleBranchsAuthListInsteadGroupIds { get; set; }
        public virtual DbSet<NgacAuthlog> NgacAuthlogs { get; set; }
        public virtual DbSet<NotificationList> NotificationLists { get; set; }
        public virtual DbSet<NotificationUserList> NotificationUserLists { get; set; }
        public virtual DbSet<PayApplySchedule> PayApplySchedules { get; set; }
        public virtual DbSet<PayCompare> PayCompares { get; set; }
        public virtual DbSet<PayCompare1> PayCompares1 { get; set; }
        public virtual DbSet<PaySeq> PaySeqs { get; set; }
        public virtual DbSet<PayrollHistory> PayrollHistories { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonEmail> PersonEmails { get; set; }
        public virtual DbSet<PersonInsuranceList> PersonInsuranceLists { get; set; }
        public virtual DbSet<PersonPhone> PersonPhones { get; set; }
        public virtual DbSet<PersonPicture> PersonPictures { get; set; }
        public virtual DbSet<PhoneList> PhoneLists { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<RefAddress> RefAddresses { get; set; }
        public virtual DbSet<RefApprovalStatus> RefApprovalStatuses { get; set; }
        public virtual DbSet<RefAuthType> RefAuthTypes { get; set; }
        public virtual DbSet<RefBank> RefBanks { get; set; }
        public virtual DbSet<RefBankType> RefBankTypes { get; set; }
        public virtual DbSet<RefCommentType> RefCommentTypes { get; set; }
        public virtual DbSet<RefCompanyType> RefCompanyTypes { get; set; }
        public virtual DbSet<RefDepartmentType> RefDepartmentTypes { get; set; }
        public virtual DbSet<RefDocumentType> RefDocumentTypes { get; set; }
        public virtual DbSet<RefGenderType> RefGenderTypes { get; set; }
        public virtual DbSet<RefImageType> RefImageTypes { get; set; }
        public virtual DbSet<RefInsuranceCompany> RefInsuranceCompanies { get; set; }
        public virtual DbSet<RefInsurancePlan> RefInsurancePlans { get; set; }
        public virtual DbSet<RefInsuranceType> RefInsuranceTypes { get; set; }
        public virtual DbSet<RefLeavesOfAbsence> RefLeavesOfAbsences { get; set; }
        public virtual DbSet<RefNetworkType> RefNetworkTypes { get; set; }
        public virtual DbSet<RefPayPeriodType> RefPayPeriodTypes { get; set; }
        public virtual DbSet<RefPayType> RefPayTypes { get; set; }
        public virtual DbSet<RefPhoneType> RefPhoneTypes { get; set; }
        public virtual DbSet<RefRelationshipType> RefRelationshipTypes { get; set; }
        public virtual DbSet<RefRetiredType> RefRetiredTypes { get; set; }
        public virtual DbSet<RefScheduleType> RefScheduleTypes { get; set; }
        public virtual DbSet<RefTerminate> RefTerminates { get; set; }
        public virtual DbSet<RefVisaStatus> RefVisaStatuses { get; set; }
        public virtual DbSet<RegOtPayStatusDetail> RegOtPayStatusDetails { get; set; }
        public virtual DbSet<RegOtPayStatusHistory> RegOtPayStatusHistories { get; set; }
        public virtual DbSet<RegOtPayStatusMaster> RegOtPayStatusMasters { get; set; }
        public virtual DbSet<RetroDetail> RetroDetails { get; set; }
        public virtual DbSet<RetroHistory> RetroHistories { get; set; }
        public virtual DbSet<RetroType> RetroTypes { get; set; }
        public virtual DbSet<RightForm> RightForms { get; set; }
        public virtual DbSet<RightSubForm> RightSubForms { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SettingTable> SettingTables { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<StaffingAttendance> StaffingAttendances { get; set; }
        public virtual DbSet<StaffingCompanyPayseq> StaffingCompanyPayseqs { get; set; }
        public virtual DbSet<StaffingDailyAttendance> StaffingDailyAttendances { get; set; }
        public virtual DbSet<StaffingDailyAttendanceLog> StaffingDailyAttendanceLogs { get; set; }
        public virtual DbSet<StaffingEmployeeList> StaffingEmployeeLists { get; set; }
        public virtual DbSet<StaffingUser> StaffingUsers { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<SubApplicationForm> SubApplicationForms { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyEmployee> SurveyEmployees { get; set; }
        public virtual DbSet<SurveyEmployeeHistory> SurveyEmployeeHistories { get; set; }
        public virtual DbSet<SurveyReviewer> SurveyReviewers { get; set; }
        public virtual DbSet<SystemLogInOut> SystemLogInOuts { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<TEmployee> TEmployees { get; set; }
        public virtual DbSet<TGenderType> TGenderTypes { get; set; }
        public virtual DbSet<TPersonPhone> TPersonPhones { get; set; }
        public virtual DbSet<TPhoneType> TPhoneTypes { get; set; }
        public virtual DbSet<TerminalList> TerminalLists { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<UnitPayseq> UnitPayseqs { get; set; }
        public virtual DbSet<UserGroupCompany> UserGroupCompanies { get; set; }
        public virtual DbSet<UserPassword> UserPasswords { get; set; }
        public virtual DbSet<VAttendanceByEmpId> VAttendanceByEmpIds { get; set; }
        public virtual DbSet<VCompany> VCompanies { get; set; }
        public virtual DbSet<VCompanyHistoryByEmpId> VCompanyHistoryByEmpIds { get; set; }
        public virtual DbSet<VCompanyPaySeq> VCompanyPaySeqs { get; set; }
        public virtual DbSet<VDailyAttendanceCount> VDailyAttendanceCounts { get; set; }
        public virtual DbSet<VDailyStatusLogFull> VDailyStatusLogFulls { get; set; }
        public virtual DbSet<VDepartment> VDepartments { get; set; }
        public virtual DbSet<VEmployeeBank> VEmployeeBanks { get; set; }
        public virtual DbSet<VEmployeeCommentByEmployeeId> VEmployeeCommentByEmployeeIds { get; set; }
        public virtual DbSet<VEmployeeCompensation> VEmployeeCompensations { get; set; }
        public virtual DbSet<VEmployeeDailyAttendance> VEmployeeDailyAttendances { get; set; }
        public virtual DbSet<VEmployeeDemographic> VEmployeeDemographics { get; set; }
        public virtual DbSet<VEmployeeDetail> VEmployeeDetails { get; set; }
        public virtual DbSet<VEmployeeFull> VEmployeeFulls { get; set; }
        public virtual DbSet<VEmployeeInsuranceSummary> VEmployeeInsuranceSummaries { get; set; }
        public virtual DbSet<VEmployeeListForNitgen> VEmployeeListForNitgens { get; set; }
        public virtual DbSet<VEmployeeListforAme> VEmployeeListforAmes { get; set; }
        public virtual DbSet<VEmployeeScheduleFull> VEmployeeScheduleFulls { get; set; }
        public virtual DbSet<VEmployeeStatus> VEmployeeStatuses { get; set; }
        public virtual DbSet<VGroupCompanyLocation> VGroupCompanyLocations { get; set; }
        public virtual DbSet<VImage> VImages { get; set; }
        public virtual DbSet<VLocation> VLocations { get; set; }
        public virtual DbSet<VPayApplySchedule> VPayApplySchedules { get; set; }
        public virtual DbSet<VPayApplyScheduleHourly> VPayApplyScheduleHourlies { get; set; }
        public virtual DbSet<VRetroEmployeeList> VRetroEmployeeLists { get; set; }
        public virtual DbSet<VSection> VSections { get; set; }
        public virtual DbSet<WarningType> WarningTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=p4nets.ddns.net, 20143;Initial Catalog=P4N_HRM_DEV;User ID=p4net_user;Password=p4net_u52r;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddresseList>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_Address_1");

                entity.ToTable("AddresseList", "Base");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))")
                    .HasComment("ISO standard code for countries and regions.");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.AddresseLists)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_RefAddress");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.AddresseLists)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddresseList_CountryRegion");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.AddresseLists)
                    .HasForeignKey(d => d.StateProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_StateProvince");
            });

            modelBuilder.Entity<ApplicationForm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("ApplicationForms", "Apps");

                entity.Property(e => e.FormId)
                    .HasColumnName("FormID")
                    .HasComment("Form list");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CaptionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ArchcoPunch>(entity =>
            {
                entity.HasKey(e => new { e.Cveid, e.Archid, e.Date, e.Ptime, e.Ptype, e.UpdateDt });

                entity.ToTable("ARCHCO_PUNCH", "ThirdParty");

                entity.Property(e => e.Cveid)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CVEID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Archid)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ARCHID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptime)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PTime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ptype)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PType")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CoName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CO_NAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fname)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("FName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayRate)
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Authority>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Authority", "Apps");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark).HasMaxLength(128);

                entity.Property(e => e.Requester)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch", "Company");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminateDate).HasColumnType("date");
            });

            modelBuilder.Entity<BranchCompany>(entity =>
            {
                entity.ToTable("BranchCompany", "Company");

                entity.Property(e => e.BranchCompanyId).HasColumnName("BranchCompanyID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.BranchCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchCompany_Company");

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.BranchCompanies)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchCompany_GroupCompany");
            });

            modelBuilder.Entity<BuildVersion>(entity =>
            {
                entity.HasKey(e => new { e.VersionMajor, e.VersionMinor, e.VersionBuild, e.VersionRevision })
                    .HasName("PK_Version");

                entity.ToTable("BuildVersion", "Apps");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("CreateID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("ModifiedID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.WorkDate);

                entity.ToTable("Calendar", "Times");

                entity.HasIndex(e => e.WorkDay, "IX_Calendar");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company", "Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodTypeId).HasColumnName("PayPeriodTypeID");

                entity.Property(e => e.RegisterDate).HasColumnType("date");

                entity.Property(e => e.TerminateDate).HasColumnType("date");

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CompanyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_RefCompanyType");

                entity.HasOne(d => d.PayPeriodType)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.PayPeriodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_RefPayPeriodType");
            });

            modelBuilder.Entity<CompanyHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.HireDate })
                    .HasName("PK_CompanyHistory_1");

                entity.ToTable("CompanyHistory", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.RetiredTypeId).HasColumnName("RetiredTypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CompanyHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkEmployee_Employee");

                entity.HasOne(d => d.RetiredType)
                    .WithMany(p => p.CompanyHistories)
                    .HasForeignKey(d => d.RetiredTypeId)
                    .HasConstraintName("FK_CompanyHistory_RefRetiredType");
            });

            modelBuilder.Entity<CompanyPaySeq>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PaySeqId });

                entity.ToTable("CompanyPaySeq", "Pay");

                entity.HasIndex(e => new { e.CompanyId, e.PaySeqId, e.PaidFlag }, "IX_CompanyPaySeq");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.PaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyPaySeqs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyPaySeq_Company");

                entity.HasOne(d => d.PaySeq)
                    .WithMany(p => p.CompanyPaySeqs)
                    .HasForeignKey(d => d.PaySeqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyPaySeq_PaySeq");
            });

            modelBuilder.Entity<CountryRegion>(entity =>
            {
                entity.HasKey(e => e.CountryRegionCode)
                    .HasName("PK_CountryRegion_CountryRegionCode");

                entity.ToTable("CountryRegion", "Base");

                entity.HasComment("Lookup table containing the ISO standard codes for countries and regions.");

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))")
                    .HasComment("ISO standard code for countries and regions.");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Country or region name.");
            });

            modelBuilder.Entity<DailyAttendance>(entity =>
            {
                entity.HasKey(e => new { e.WorkDate, e.EmployeeId, e.Created });

                entity.ToTable("DailyAttendance", "Times");

                entity.HasIndex(e => new { e.EmployeeId, e.WorkDate, e.PunchIn, e.PunchOut, e.ConfirmIn, e.ConfirmOut }, "IX_DailyAttendance")
                    .IsUnique();

                entity.HasIndex(e => new { e.ConfirmIn, e.ConfirmOut, e.WorkDate, e.PunchIn, e.PunchOut }, "IX_RegOtIndex");

                entity.HasIndex(e => new { e.WorkDate, e.ConfirmIn, e.ConfirmOut, e.PunchIn, e.PunchOut, e.ExceptionTypeId }, "IX_RegularHour_Confirm");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.ConfirmIn).HasColumnType("datetime");

                entity.Property(e => e.ConfirmOut).HasColumnType("datetime");

                entity.Property(e => e.CreateLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExceptionTypeId).HasColumnName("ExceptionTypeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.MealMinDinner).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PunchIn).HasColumnType("datetime");

                entity.Property(e => e.PunchOut).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.WarningTypeId).HasColumnName("WarningTypeID");

                entity.Property(e => e.WarningYn).HasColumnName("WarningYN");

                entity.Property(e => e.WorkMin).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DailyAttendances)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyAttendance_Employee");

                entity.HasOne(d => d.ExceptionType)
                    .WithMany(p => p.DailyAttendances)
                    .HasForeignKey(d => d.ExceptionTypeId)
                    .HasConstraintName("FK_DailyAttendance_ExceptionType");
            });

            modelBuilder.Entity<DailyAttendanceLog>(entity =>
            {
                entity.HasKey(e => new { e.WorkDate, e.EmployeeId, e.Created, e.Modified, e.Flag });

                entity.ToTable("DailyAttendance_Log", "Times");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasMaxLength(50);

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.ConfirmIn).HasColumnType("datetime");

                entity.Property(e => e.ConfirmOut).HasColumnType("datetime");

                entity.Property(e => e.CreateLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExceptionTypeId).HasColumnName("ExceptionTypeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.MealMinDinner).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PunchIn).HasColumnType("datetime");

                entity.Property(e => e.PunchOut).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WarningTypeId).HasColumnName("WarningTypeID");

                entity.Property(e => e.WarningYn)
                    .HasColumnName("WarningYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkMin).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DailyStatusLog>(entity =>
            {
                entity.HasKey(e => new { e.WorkDate, e.EmployeeId });

                entity.ToTable("DailyStatusLog", "Employee");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.BillingPayRate).HasColumnType("money");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyStatusLog_Company");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkHours_Employee");

                entity.HasOne(d => d.GrpCompLoc)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.GrpCompLocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyStatusLog_GroupCompanyLocation");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.PayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyStatusLog_PayType");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyStatusLog_Position");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyStatusLog_Section");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.DailyStatusLogs)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DailyStatusLog_Shift");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "Company");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DepartmentId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentTypeId).HasColumnName("DepartmentTypeID");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DepartmentType)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.DepartmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_RefDepartmentType");

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_GroupCompany");
            });

            modelBuilder.Entity<DepartmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.AppliedDate, e.EmployeeId });

                entity.ToTable("DepartmentHistory", "Company");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentHistories)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentHistory_Department");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DepartmentHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentHistory_Employee");
            });

            modelBuilder.Entity<EeList02142019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EE List_02142019");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateHired)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date Hired");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee E-mail");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee First Name");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee Last Name");

                entity.Property(e => e.EmployeeMiddleInitial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee Middle Initial");

                entity.Property(e => e.HourlyBillingRate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Hourly Billing Rate");

                entity.Property(e => e.Inactive)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EffexGroupcompany>(entity =>
            {
                entity.HasKey(e => e.CompanyLocationId);

                entity.ToTable("EffexGroupcompany", "ThirdParty");

                entity.Property(e => e.CompanyLocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("CompanyLocationID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLocationIdCve).HasColumnName("CompanyLocationID_CVE");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<EffexOrganization>(entity =>
            {
                entity.HasKey(e => e.OrganizationId);

                entity.ToTable("EffexOrganization", "ThirdParty");

                entity.Property(e => e.OrganizationId)
                    .HasMaxLength(10)
                    .HasColumnName("OrganizationID")
                    .IsFixedLength(true);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCve)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Department_CVE");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionCve)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Section_CVE");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdCve).HasColumnName("SectionID_CVE");
            });

            modelBuilder.Entity<EmailList>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("EmailList", "Person");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmegPersonId, e.Created });

                entity.ToTable("EmergencyContact", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmegPersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmegPersonID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

                entity.HasOne(d => d.EmegPerson)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.EmegPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContact_Person");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContact_Employee");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.RelationshipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContact_RefRelationshipType");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "Employee");

                entity.HasIndex(e => new { e.EmployeeId, e.PersonId, e.CompanyId, e.GrpCompLocId, e.SectionId, e.PositionId, e.ShiftId, e.RetiredTypeId, e.PayTypeId }, "IX_Employee_Detail");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.AdditionalPayAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalPayRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BillingPayRate)
                    .HasColumnType("decimal(24, 6)")
                    .HasComputedColumnSql("(isnull(case when [AdditionalPayType]=(0) then [PayRate]+[AdditionalPayAmount] else case when [AdditionalPayRate]=(0) then [PayRate] else [PayRate]+[PayRate]*[AdditionalPayRate] end end,(0)))", false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.RetiredTypeId).HasColumnName("RetiredTypeID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Company");

                entity.HasOne(d => d.GrpCompLoc)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.GrpCompLocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_GroupCompanyLocation");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_PayType");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Person");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Position");

                entity.HasOne(d => d.RetiredType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.RetiredTypeId)
                    .HasConstraintName("FK_Employee_RefRetiredType");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Section");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Shift");
            });

            modelBuilder.Entity<EmployeeAccount>(entity =>
            {
                entity.ToTable("EmployeeAccount", "Employee");

                entity.Property(e => e.EmployeeAccountId).HasColumnName("EmployeeAccountID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankTypeId).HasColumnName("BankTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RoutingNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.EmployeeAccounts)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAccount_RefBank");

                entity.HasOne(d => d.BankType)
                    .WithMany(p => p.EmployeeAccounts)
                    .HasForeignKey(d => d.BankTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAccount_RefBankType");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAccounts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAccount_Employee");
            });

            modelBuilder.Entity<EmployeeComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("EmployeeComment", "Employee");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RequestID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.CommentType)
                    .WithMany(p => p.EmployeeComments)
                    .HasForeignKey(d => d.CommentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeComment_RefCommentType");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeComments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeComment_Employee");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.EmployeeComments)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeComment_RefApprovalStatus");
            });

            modelBuilder.Entity<EmployeeDocument>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.DocumentTypeId });

                entity.ToTable("EmployeeDocument", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.EmployeeDocuments)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDocument_RefDocumentType");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeDocuments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDocument_Employee");
            });

            modelBuilder.Entity<EmployeeLeaf>(entity =>
            {
                entity.HasKey(e => e.LeavesId);

                entity.ToTable("EmployeeLeaves", "Employee");

                entity.HasIndex(e => new { e.EmployeeId, e.LoatypeId, e.StatusId, e.StartDate, e.EndDate, e.ActiveFlag }, "IX_EmployeeLeaves");

                entity.Property(e => e.LeavesId).HasColumnName("LeavesID");

                entity.Property(e => e.ApprovalId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ApprovalID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LoatypeId).HasColumnName("LOATypeID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Approval)
                    .WithMany(p => p.EmployeeLeafApprovals)
                    .HasForeignKey(d => d.ApprovalId)
                    .HasConstraintName("FK_EmployeeLeaves_Employee2");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeLeafEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaves_Employee1");

                entity.HasOne(d => d.Loatype)
                    .WithMany(p => p.EmployeeLeaves)
                    .HasForeignKey(d => d.LoatypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaves_RefLeavesOfAbsence");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.EmployeeLeaves)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeaves_RefApprovalStatus");
            });

            modelBuilder.Entity<EmployeePayrollHistory>(entity =>
            {
                entity.HasKey(e => new { e.CompanyLocation, e.InvoiceNumber, e.StaffingId, e.WeekendDate, e.PayCode, e.PayRate })
                    .HasName("PK_EmployeePayrollHistoy");

                entity.ToTable("EmployeePayrollHistory", "ThirdParty");

                entity.Property(e => e.CompanyLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.WeekendDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PayCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.FeeAmount).HasColumnType("money");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OtherAmount).HasColumnType("money");

                entity.Property(e => e.OvertimeAmount).HasColumnType("money");

                entity.Property(e => e.OvertimeHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PaytypeId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PaytypeID");

                entity.Property(e => e.RegularAmount).HasColumnType("money");

                entity.Property(e => e.RegularHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("money");
            });

            modelBuilder.Entity<EmployeePicture>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.ImageId });

                entity.ToTable("EmployeePicture", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePictures)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeePicture_Employee");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.EmployeePictures)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeePicture_ImageList");
            });

            modelBuilder.Entity<EmployeeRefIdhistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.HireDate, e.CompanyId });

                entity.ToTable("EmployeeRefIDHistory", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.IsStaffing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RefEmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RefEmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRefIdhistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRefIDHistory_Employee");
            });

            modelBuilder.Entity<EmployeeRelationshipList>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.PersonId });

                entity.ToTable("EmployeeRelationshipList", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRelationshipLists)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRelationshipList_Employee");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EmployeeRelationshipLists)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRelationshipList_Person");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.EmployeeRelationshipLists)
                    .HasForeignKey(d => d.RelationshipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRelationshipList_RefRelationshipType");
            });

            modelBuilder.Entity<EmployeeSchedule>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.AppliedDate });

                entity.ToTable("EmployeeSchedule", "Employee");

                entity.HasIndex(e => new { e.AppliedFlag, e.ActiveFlag, e.AppliedDate }, "IX_ScheduleHistory");

                entity.HasIndex(e => new { e.AppliedFlag, e.ActiveFlag, e.AppliedDate }, "IX_ScheduleHistory>");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSchedules)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSchedule_Employee");

                entity.HasOne(d => d.GrpCompLoc)
                    .WithMany(p => p.EmployeeSchedules)
                    .HasForeignKey(d => d.GrpCompLocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSchedule_GroupCompanyLocation");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.EmployeeSchedules)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSchedule_Section");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.EmployeeSchedules)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSchedule_Shift");
            });

            modelBuilder.Entity<EmployeeStaffingId>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.AppliedDate })
                    .HasName("PK_EmployeeStaffingID_1");

                entity.ToTable("EmployeeStaffingID", "Employee");

                entity.HasIndex(e => e.AppliedDate, "IX_EmployeeStaffing");

                entity.HasIndex(e => new { e.EmployeeId, e.ActiveFlag, e.StaffingId }, "IX_EmployeeStaffingID");

                entity.HasIndex(e => new { e.EmployeeId, e.AppliedDate, e.CompanyId }, "IX_EmployeeStaffingID_001")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.AppliedDate).HasColumnType("date");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.StaffingId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeStaffingIds)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeStaffingID_Employee1");
            });

            modelBuilder.Entity<EmployeeStaffingIdhistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.AppliedDate, e.CompanyId });

                entity.ToTable("EmployeeStaffingIDHistory", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.AppliedDate).HasColumnType("date");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.StaffingId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");
            });

            modelBuilder.Entity<ExceptionType>(entity =>
            {
                entity.ToTable("ExceptionType", "Times");

                entity.Property(e => e.ExceptionTypeId).HasColumnName("ExceptionTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<FeeList>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.StartDate })
                    .HasName("PK_FeeList_1");

                entity.ToTable("FeeList", "Pay");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.MarkUpFeeAmt).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.MarkUpFeeOt)
                    .HasColumnType("numeric(5, 4)")
                    .HasColumnName("MarkUpFeeOT");

                entity.Property(e => e.MarkUpFeeOtamt)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("MarkUpFeeOTAmt");

                entity.Property(e => e.MarkupFee).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.MarkupType)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0:Rate, 1:Amount");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<GroupAuthList>(entity =>
            {
                entity.HasKey(e => new { e.MenuAuthId, e.GroupId });

                entity.ToTable("GroupAuthList", "Apps");

                entity.Property(e => e.MenuAuthId).HasColumnName("MenuAuthID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupAuthLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAuthList_GroupList");

                entity.HasOne(d => d.MenuAuth)
                    .WithMany(p => p.GroupAuthLists)
                    .HasForeignKey(d => d.MenuAuthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAuthList_MenuAuthList1");
            });

            modelBuilder.Entity<GroupCompany>(entity =>
            {
                entity.ToTable("GroupCompany", "Company");

                entity.Property(e => e.GroupCompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("GroupCompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.GroupCompanyNavigation)
                    .WithOne(p => p.GroupCompany)
                    .HasForeignKey<GroupCompany>(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupCompany_Company");
            });

            modelBuilder.Entity<GroupCompanyLocation>(entity =>
            {
                entity.HasKey(e => e.GrpCompLocId)
                    .HasName("PK_GroupCompanyLocation_1");

                entity.ToTable("GroupCompanyLocation", "Company");

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.GroupCompanyLocations)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupCompanyLocation_GroupCompany");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.GroupCompanyLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupCompanyLocation_Location");
            });

            modelBuilder.Entity<GroupList>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("GroupList", "Apps");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<GroupUserList>(entity =>
            {
                entity.HasKey(e => new { e.SystemUserListId, e.GroupId })
                    .HasName("PK_GroupUserList_1");

                entity.ToTable("GroupUserList", "Apps");

                entity.Property(e => e.SystemUserListId).HasColumnName("SystemUserListID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupUserLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUserList_GroupList");

                entity.HasOne(d => d.SystemUserList)
                    .WithMany(p => p.GroupUserLists)
                    .HasForeignKey(d => d.SystemUserListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUserList_SystemUsers");
            });

            modelBuilder.Entity<HourSeq>(entity =>
            {
                entity.HasKey(e => e.HourId);

                entity.ToTable("HourSeq", "Times");

                entity.Property(e => e.HourId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("HourID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Idprefix>(entity =>
            {
                entity.ToTable("IDPrefix", "Base");

                entity.Property(e => e.IdprefixId).HasColumnName("IDPrefixID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageList>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("ImageList", "Apps");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.ImageText)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ImageTypeId).HasColumnName("ImageTypeID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.ImageType)
                    .WithMany(p => p.ImageLists)
                    .HasForeignKey(d => d.ImageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageList_RefImageType");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.StaffingId });

                entity.ToTable("InvoiceDetail", "Pay");

                entity.HasIndex(e => e.InvoiceId, "IX_InvoiceDetail");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.AltEmpId).HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<InvoiceDiscrepancyReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvoiceDiscrepancyReport", "Pay");

                entity.Property(e => e.AltEmpId).HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Cvefee).HasColumnName("CVEFee");

                entity.Property(e => e.Cvegross).HasColumnName("CVEGross");

                entity.Property(e => e.CvepayRate)
                    .HasColumnType("money")
                    .HasColumnName("CVEPayRate");

                entity.Property(e => e.Cvetotal).HasColumnName("CVETotal");

                entity.Property(e => e.CvetotalHr).HasColumnName("CVETotalHr");

                entity.Property(e => e.EffexTotal)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PayrateDiff)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Reason).HasMaxLength(128);

                entity.Property(e => e.SearchDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StaffingId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.TotalDiff)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("InvoiceMaster", "Pay");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.StaffingInvoiceId)
                    .HasMaxLength(10)
                    .HasColumnName("StaffingInvoiceID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.StaffingCompanyPayseq)
                    .WithMany(p => p.InvoiceMasters)
                    .HasForeignKey(d => new { d.CompanyId, d.PaySeqId, d.GroupCompanyId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceMaster_StaffingCompanyPayseq");
            });

            modelBuilder.Entity<LeavesOfAbsence>(entity =>
            {
                entity.HasKey(e => e.Loaid);

                entity.ToTable("LeavesOfAbsence", "Employee");

                entity.HasIndex(e => e.WorkDate, "IX_RegOtLeaves");

                entity.Property(e => e.Loaid).HasColumnName("LOAID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LeavesId).HasColumnName("LeavesID");

                entity.Property(e => e.Loahour)
                    .HasColumnType("decimal(6, 1)")
                    .HasColumnName("LOAHour");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Leaves)
                    .WithMany(p => p.LeavesOfAbsences)
                    .HasForeignKey(d => d.LeavesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeavesOfAbsence_EmployeeLeaves");

                entity.HasOne(d => d.WorkDateNavigation)
                    .WithMany(p => p.LeavesOfAbsences)
                    .HasForeignKey(d => d.WorkDate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeavesOfAbsence_Calendar");
            });

            modelBuilder.Entity<LeavesOfTheYear>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.Year, e.LoatypeId })
                    .HasName("PK_EmployeeLeavesOfAbsence");

                entity.ToTable("LeavesOfTheYear", "Employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LoatypeId).HasColumnName("LOATypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Loatype)
                    .WithMany(p => p.LeavesOfTheYears)
                    .HasForeignKey(d => d.LoatypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeLeavesOfTheYear_RefLeavesOfAbsence");
            });

            modelBuilder.Entity<LeavesOfTheYearAdded>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.AllowedDate, e.LoatypeId });

                entity.ToTable("LeavesOfTheYearAdded", "Employee");

                entity.HasComment("Speicial Allowed History");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.AllowedDate).HasColumnType("date");

                entity.Property(e => e.LoatypeId).HasColumnName("LOATypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark).HasMaxLength(100);
            });

            modelBuilder.Entity<LeavesPolicy>(entity =>
            {
                entity.HasKey(e => new { e.ServiceYear, e.LoatypeId, e.PayTypeId, e.Version });

                entity.ToTable("LeavesPolicy", "Employee");

                entity.Property(e => e.LoatypeId).HasColumnName("LOATypeID");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Loatype)
                    .WithMany(p => p.LeavesPolicies)
                    .HasForeignKey(d => d.LoatypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeavesPolicy_RefLeavesOfAbsence");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.LeavesPolicies)
                    .HasForeignKey(d => d.PayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeavesPolicy_RefPayType");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location", "Company");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationAddress>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.AddressId })
                    .HasName("PK_CompanyAddress");

                entity.ToTable("LocationAddress", "Company");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.LocationAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationAddress_Addresses");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationAddresses)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationAddress_Location");
            });

            modelBuilder.Entity<LogDailyAttendance>(entity =>
            {
                entity.HasKey(e => e.Created);

                entity.ToTable("LogDailyAttendance", "Log");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChangeFlag)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmIn)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmInChanged)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmOut)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmOutChanged)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ExceptionTypeId).HasColumnName("ExceptionTypeID");

                entity.Property(e => e.ExceptionTypeIdchanged).HasColumnName("ExceptionTypeIDChanged");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PunchIn).HasColumnType("datetime");

                entity.Property(e => e.PunchInChanged).HasColumnType("datetime");

                entity.Property(e => e.PunchOut).HasColumnType("datetime");

                entity.Property(e => e.PunchOutChanged).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogErrorCode>(entity =>
            {
                entity.HasKey(e => e.ErroLogId);

                entity.ToTable("LogErrorCode", "Log");

                entity.Property(e => e.ErroLogId).HasColumnName("ErroLogID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WindowName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogFormUsage>(entity =>
            {
                entity.HasKey(e => e.FormOpenDate);

                entity.ToTable("LogFormUsage", "Log");

                entity.Property(e => e.FormOpenDate).HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.InOutFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.LogFormUsages)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogFormUsage_ApplicationForms");
            });

            modelBuilder.Entity<LogTransactionError>(entity =>
            {
                entity.HasKey(e => new { e.ErrorNumber, e.Created });

                entity.ToTable("LogTransactionError", "Log");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.ErrorProcedure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorSeverity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MaritalStatusType>(entity =>
            {
                entity.ToTable("MaritalStatusType", "Person");

                entity.Property(e => e.MaritalStatusTypeId).HasColumnName("MaritalStatusTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MartitalStatusType>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusTypeId);

                entity.ToTable("MartitalStatusType", "Test");

                entity.Property(e => e.MaritalStatusTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("MaritalStatusTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Mboemployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("MBOEmployee", "MBO");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Manager1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Manager2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Manager3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MbogroupId).HasColumnName("MBOGroupID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.Mboemployee)
                    .HasForeignKey<Mboemployee>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MBOEmployee_Employee");
            });

            modelBuilder.Entity<MboemployeeHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.Year });

                entity.ToTable("MBOEmployeeHistory", "MBO");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Manager1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Manager2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Manager3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Mbogroup>(entity =>
            {
                entity.ToTable("MBOGroup", "MBO");

                entity.Property(e => e.MbogroupId).HasColumnName("MBOGroupID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MealMinuteSeq>(entity =>
            {
                entity.HasKey(e => e.MealId);

                entity.ToTable("MealMinuteSeq", "Times");

                entity.Property(e => e.MealId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MealID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MenuAuthList>(entity =>
            {
                entity.HasKey(e => e.MenuAuthId);

                entity.ToTable("MenuAuthList", "Apps");

                entity.HasIndex(e => e.MenuAuthId, "IX_MenuAuthList")
                    .IsUnique();

                entity.Property(e => e.MenuAuthId).HasColumnName("MenuAuthID");

                entity.Property(e => e.AuthTypeId).HasColumnName("AuthTypeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.AuthType)
                    .WithMany(p => p.MenuAuthLists)
                    .HasForeignKey(d => d.AuthTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuAuthList_AuthType");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuAuthLists)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuAuthList_MenuList");
            });

            modelBuilder.Entity<MenuList>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("MenuList", "Apps");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MinWage>(entity =>
            {
                entity.HasKey(e => e.WageId);

                entity.ToTable("MinWage", "Pay");

                entity.Property(e => e.WageId).HasColumnName("WageID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Wage).HasColumnType("money");
            });

            modelBuilder.Entity<MinuteSeq>(entity =>
            {
                entity.HasKey(e => e.MinuteId);

                entity.ToTable("MinuteSeq", "Times");

                entity.Property(e => e.MinuteId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MinuteID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MultipleBranchsAuthListInsteadGroupId>(entity =>
            {
                entity.HasKey(e => new { e.SystemUserListId, e.GroupCompanyId, e.MenuAuthId });

                entity.ToTable("MultipleBranchsAuthListInsteadGroupID", "Apps");

                entity.Property(e => e.SystemUserListId).HasColumnName("SystemUserListID");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.MenuAuthId).HasColumnName("MenuAuthID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.SystemUserList)
                    .WithMany(p => p.MultipleBranchsAuthListInsteadGroupIds)
                    .HasForeignKey(d => d.SystemUserListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MultipleBranchsAuthListInsteadGroupID_SystemUsers");
            });

            modelBuilder.Entity<NgacAuthlog>(entity =>
            {
                entity.HasKey(e => e.IndexKey)
                    .HasName("PK_Times_NGAC_AUTHLOG");

                entity.ToTable("NGAC_AUTHLOG", "Times");

                entity.Property(e => e.IndexKey).ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('TerminalDB')");

                entity.Property(e => e.DeleteFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.HostName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.ServerRecordTime).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TransDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIdindex).HasColumnName("UserIDIndex");
            });

            modelBuilder.Entity<NotificationList>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("NotificationList", "Apps");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationUserList>(entity =>
            {
                entity.HasKey(e => new { e.GroupCompanyId, e.EmployeeId, e.NotificationId });

                entity.ToTable("NotificationUserList", "Apps");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.NotificationUserLists)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationUserList_Employee");

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.NotificationUserLists)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationUserList_GroupCompany");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationUserLists)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationUserList_NotificationList");
            });

            modelBuilder.Entity<PayApplySchedule>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EffectivePaySeqId })
                    .HasName("PK_PayApplySchedule_1");

                entity.ToTable("PayApplySchedule", "Pay");

                entity.HasIndex(e => e.RequestEmployeeId, "IX_PayApplySchedule");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EffectivePaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EffectivePaySeqID");

                entity.Property(e => e.AdditionalPayAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalPayRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BillingPayRate)
                    .HasColumnType("decimal(24, 6)")
                    .HasComputedColumnSql("(isnull(case when [AdditionalPayType]=(0) then [PayRate]+[AdditionalPayAmount] else case when [AdditionalPayRate]=(0) then [PayRate] else [PayRate]+[PayRate]*[AdditionalPayRate] end end,(0)))", false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExpiredPaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExpiredPaySeqID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.RequestEmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RequestEmployeeID");

                entity.HasOne(d => d.EffectivePaySeq)
                    .WithMany(p => p.PayApplySchedules)
                    .HasForeignKey(d => d.EffectivePaySeqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayApplySchedule_PaySeq");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PayApplySchedules)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayApplySchedule_Employee");

                entity.HasOne(d => d.PayType)
                    .WithMany(p => p.PayApplySchedules)
                    .HasForeignKey(d => d.PayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayApplySchedule_RefPayType");
            });

            modelBuilder.Entity<PayCompare>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayCompare", "Apps");

                entity.Property(e => e.AltEmpId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OvtHours).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OvtRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.OvtWages).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.PayRate).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RegHours).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RegWages).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<PayCompare1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayCompare", "Test");

                entity.Property(e => e.AltEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fee).HasColumnType("money");

                entity.Property(e => e.Gross).HasColumnType("money");

                entity.Property(e => e.OvtHours).HasColumnType("money");

                entity.Property(e => e.OvtRate).HasColumnType("money");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.RegHours).HasColumnType("money");

                entity.Property(e => e.RegWages).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<PaySeq>(entity =>
            {
                entity.ToTable("PaySeq", "Pay");

                entity.Property(e => e.PaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DateAdded)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.PayPeriodTypeId).HasColumnName("PayPeriodTypeID");

                entity.Property(e => e.PayYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SeqEnd).HasColumnType("date");

                entity.Property(e => e.SeqStart).HasColumnType("date");

                entity.HasOne(d => d.PayPeriodType)
                    .WithMany(p => p.PaySeqs)
                    .HasForeignKey(d => d.PayPeriodTypeId)
                    .HasConstraintName("FK_PaySeq_RefPayPeriodType");
            });

            modelBuilder.Entity<PayrollHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.PaySeqId, e.CompanyId, e.PayweekId })
                    .HasName("PK_PayrollHistory_1");

                entity.ToTable("PayrollHistory", "Pay");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.PaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.PayweekId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PayweekID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HolidayHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LeavesAmount).HasColumnType("money");

                entity.Property(e => e.LeavesHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NonPaidLeavesHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.OvertimeAmount).HasColumnType("money");

                entity.Property(e => e.OvertimeHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PaytypeId).HasColumnName("PaytypeID");

                entity.Property(e => e.RegularAmount).HasColumnType("money");

                entity.Property(e => e.RegularHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.RetroAmount).HasColumnType("money");

                entity.Property(e => e.RetroHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.SickDayHour).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.VacationHour).HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PayrollHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayrollHistory_Employee");

                entity.HasOne(d => d.Paytype)
                    .WithMany(p => p.PayrollHistories)
                    .HasForeignKey(d => d.PaytypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayrollHistory_PayType");

                entity.HasOne(d => d.CompanyPaySeq)
                    .WithMany(p => p.PayrollHistories)
                    .HasForeignKey(d => new { d.CompanyId, d.PaySeqId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayrollHistory_CompanyPaySeq");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.PayrollHistories)
                    .HasForeignKey(d => new { d.PayweekId, d.PaySeqId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayrollHistory_UnitPayseq1");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "Person");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.AliasName, e.MiddleName }, "IX_Person");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.AliasName).HasMaxLength(50);

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))")
                    .HasComment("ISO standard code for countries and regions.");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DriversLicense)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_ID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusTypeId).HasColumnName("MaritalStatusTypeID");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.VisaStatusTypeId).HasColumnName("VisaStatusTypeID");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_CountryRegion");

                entity.HasOne(d => d.GenderType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.GenderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_RefGenderType");

                entity.HasOne(d => d.MaritalStatusType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MaritalStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_MaritalStatusType");

                entity.HasOne(d => d.VisaStatusType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.VisaStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_RefVisaStatus");
            });

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.PersonId })
                    .HasName("PK_PersonAddress_1");

                entity.ToTable("PersonAddress", "Person");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PersonAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonAddress_Address");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonAddresses)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonAddress_Person");
            });

            modelBuilder.Entity<PersonEmail>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.EmailId });

                entity.ToTable("PersonEmail", "Person");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.PersonEmails)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonEmail_EmailList");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonEmails)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonEmail_Person1");
            });

            modelBuilder.Entity<PersonInsuranceList>(entity =>
            {
                entity.HasKey(e => e.InsuranceListId);

                entity.ToTable("PersonInsuranceList", "Employee");

                entity.Property(e => e.InsuranceListId).HasColumnName("InsuranceListID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.GroupNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.IdentificationNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InsurancePlanId).HasColumnName("InsurancePlanID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NetworkTypeId).HasColumnName("NetworkTypeID");

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.HasOne(d => d.InsurancePlan)
                    .WithMany(p => p.PersonInsuranceLists)
                    .HasForeignKey(d => d.InsurancePlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonInsuranceList_RefInsurancePlan");

                entity.HasOne(d => d.NetworkType)
                    .WithMany(p => p.PersonInsuranceLists)
                    .HasForeignKey(d => d.NetworkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonInsuranceList_RefNetworkType");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonInsuranceLists)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonInsuranceList_Person");
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.PhoneId })
                    .HasName("PK_PersonPhone_1");

                entity.ToTable("PersonPhone", "Person");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonPhones)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonPhone_Person2");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PersonPhones)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonPhone_Phone");
            });

            modelBuilder.Entity<PersonPicture>(entity =>
            {
                entity.HasKey(e => e.PictureId)
                    .HasName("PK_PersonPicture_1");

                entity.ToTable("PersonPicture", "Person");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonPictures)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonPicture_Person");
            });

            modelBuilder.Entity<PhoneList>(entity =>
            {
                entity.HasKey(e => e.PhoneId)
                    .HasName("PK_Phone");

                entity.ToTable("PhoneList", "Person");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExtentionNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.PhoneLists)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phone_RefPhoneType");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position", "Company");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Position_ID");

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.Positions)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Position_GroupCompany");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question", "MBO");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Encontents)
                    .HasMaxLength(200)
                    .HasColumnName("ENContents");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Krcontents)
                    .HasMaxLength(200)
                    .HasColumnName("KRContents");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Spcontents)
                    .HasMaxLength(200)
                    .HasColumnName("SPContents");

                entity.Property(e => e.SurveyId)
                    .HasColumnName("SurveyID")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Survey");
            });

            modelBuilder.Entity<RefAddress>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId)
                    .HasName("PK_AddressType");

                entity.ToTable("RefAddress", "Base");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefApprovalStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("RefApprovalStatus", "Employee");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefAuthType>(entity =>
            {
                entity.HasKey(e => e.AuthTypeId)
                    .HasName("PK_AuthType");

                entity.ToTable("RefAuthType", "Apps");

                entity.Property(e => e.AuthTypeId).HasColumnName("AuthTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefBank>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("RefBank", "Base");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefBankType>(entity =>
            {
                entity.HasKey(e => e.BankTypeId);

                entity.ToTable("RefBankType", "Base");

                entity.Property(e => e.BankTypeId).HasColumnName("BankTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefCommentType>(entity =>
            {
                entity.HasKey(e => e.CommentTypeId);

                entity.ToTable("RefCommentType", "Employee");

                entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefCompanyType>(entity =>
            {
                entity.HasKey(e => e.CompanyTypeId);

                entity.ToTable("RefCompanyType", "Company");

                entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefDepartmentType>(entity =>
            {
                entity.HasKey(e => e.DepartmentTypeId);

                entity.ToTable("RefDepartmentType", "Company");

                entity.Property(e => e.DepartmentTypeId).HasColumnName("DepartmentTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefDocumentType>(entity =>
            {
                entity.HasKey(e => e.DocumentTypeId);

                entity.ToTable("RefDocumentType", "Employee");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefGenderType>(entity =>
            {
                entity.HasKey(e => e.GenderTypeId)
                    .HasName("PK_GenderType_1");

                entity.ToTable("RefGenderType", "Person");

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefImageType>(entity =>
            {
                entity.HasKey(e => e.ImageTypeId);

                entity.ToTable("RefImageType", "Apps");

                entity.Property(e => e.ImageTypeId).HasColumnName("ImageTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefInsuranceCompany>(entity =>
            {
                entity.HasKey(e => e.InsuranceCompanyId);

                entity.ToTable("RefInsuranceCompany", "Employee");

                entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefInsurancePlan>(entity =>
            {
                entity.HasKey(e => e.InsurancePlanId);

                entity.ToTable("RefInsurancePlan", "Employee");

                entity.Property(e => e.InsurancePlanId).HasColumnName("InsurancePlanID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

                entity.Property(e => e.InsuranceTypeId).HasColumnName("InsuranceTypeID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.InsuranceCompany)
                    .WithMany(p => p.RefInsurancePlans)
                    .HasForeignKey(d => d.InsuranceCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefInsurancePlan_RefInsuranceCompany");

                entity.HasOne(d => d.InsuranceType)
                    .WithMany(p => p.RefInsurancePlans)
                    .HasForeignKey(d => d.InsuranceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefInsurancePlan_RefInsuranceType");
            });

            modelBuilder.Entity<RefInsuranceType>(entity =>
            {
                entity.HasKey(e => e.InsuranceTypeId);

                entity.ToTable("RefInsuranceType", "Employee");

                entity.Property(e => e.InsuranceTypeId).HasColumnName("InsuranceTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefLeavesOfAbsence>(entity =>
            {
                entity.HasKey(e => e.LoatypeId)
                    .HasName("PK_CommentType");

                entity.ToTable("RefLeavesOfAbsence", "Employee");

                entity.Property(e => e.LoatypeId).HasColumnName("LOATypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LoaTypeId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoaType_ID");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PaidHour).HasColumnType("numeric(4, 2)");
            });

            modelBuilder.Entity<RefNetworkType>(entity =>
            {
                entity.HasKey(e => e.NetworkTypeId);

                entity.ToTable("RefNetworkType", "Employee");

                entity.Property(e => e.NetworkTypeId).HasColumnName("NetworkTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefPayPeriodType>(entity =>
            {
                entity.HasKey(e => e.PayPeriodTypeId);

                entity.ToTable("RefPayPeriodType", "Pay");

                entity.Property(e => e.PayPeriodTypeId).HasColumnName("PayPeriodTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.WorkHourReg).HasColumnType("numeric(5, 1)");
            });

            modelBuilder.Entity<RefPayType>(entity =>
            {
                entity.HasKey(e => e.PayTypeId)
                    .HasName("PK_ClassificationType");

                entity.ToTable("RefPayType", "Pay");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.OvertimeRatio).HasColumnType("numeric(2, 1)");
            });

            modelBuilder.Entity<RefPhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeId)
                    .HasName("PK_PhoneNumberType");

                entity.ToTable("RefPhoneType", "Person");

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefRelationshipType>(entity =>
            {
                entity.HasKey(e => e.RelationshipTypeId);

                entity.ToTable("RefRelationshipType", "Employee");

                entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefRetiredType>(entity =>
            {
                entity.HasKey(e => e.RetiredTypeId);

                entity.ToTable("RefRetiredType", "Employee");

                entity.Property(e => e.RetiredTypeId).HasColumnName("RetiredTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefScheduleType>(entity =>
            {
                entity.HasKey(e => e.ScheduleTypeId);

                entity.ToTable("RefScheduleType", "Base");

                entity.Property(e => e.ScheduleTypeId).HasColumnName("ScheduleTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefTerminate>(entity =>
            {
                entity.HasKey(e => e.TerminateId)
                    .HasName("PK_TerminateType");

                entity.ToTable("RefTerminate", "Employee");

                entity.Property(e => e.TerminateId).HasColumnName("TerminateID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RefVisaStatus>(entity =>
            {
                entity.HasKey(e => e.VisaStatusTypeId);

                entity.ToTable("RefVisaStatus", "Person");

                entity.Property(e => e.VisaStatusTypeId).HasColumnName("VisaStatusTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RegOtPayStatusDetail>(entity =>
            {
                entity.HasKey(e => new { e.RegOtreportId, e.CompanyId, e.SectionId });

                entity.ToTable("RegOtPayStatusDetail", "Employee");

                entity.Property(e => e.RegOtreportId).HasColumnName("RegOTReportID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NumEe).HasColumnName("NumEE");

                entity.Property(e => e.Otamt).HasColumnName("OTAmt");

                entity.Property(e => e.Othr).HasColumnName("OTHr");

                entity.Property(e => e.OtpaidRatio).HasColumnName("OTPaidRatio");

                entity.HasOne(d => d.RegOtreport)
                    .WithMany(p => p.RegOtPayStatusDetails)
                    .HasForeignKey(d => d.RegOtreportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegOtPayStatusDetail_RegOtPayStatusMaster");
            });

            modelBuilder.Entity<RegOtPayStatusHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RegOtPayStatusHistory", "Employee");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NumEe).HasColumnName("NumEE");

                entity.Property(e => e.Otamt).HasColumnName("OTAmt");

                entity.Property(e => e.Othr).HasColumnName("OTHr");

                entity.Property(e => e.OtpaidRatio).HasColumnName("OTPaidRatio");

                entity.Property(e => e.RegOtreportId).HasColumnName("RegOTReportID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<RegOtPayStatusMaster>(entity =>
            {
                entity.HasKey(e => e.RegOtreportId);

                entity.ToTable("RegOtPayStatusMaster", "Employee");

                entity.Property(e => e.RegOtreportId).HasColumnName("RegOTReportID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");
            });

            modelBuilder.Entity<RetroDetail>(entity =>
            {
                entity.ToTable("RetroDetail", "Pay");

                entity.Property(e => e.RetroDetailId).HasColumnName("RetroDetailID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.RetroAmount).HasColumnType("money");

                entity.Property(e => e.RetroId).HasColumnName("RetroID");

                entity.HasOne(d => d.Retro)
                    .WithMany(p => p.RetroDetails)
                    .HasForeignKey(d => d.RetroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetroDetail_RetroHistory");

                entity.HasOne(d => d.CompanyPaySeq)
                    .WithMany(p => p.RetroDetails)
                    .HasForeignKey(d => new { d.CompanyId, d.PaySeqId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetroDetail_CompanyPaySeq");
            });

            modelBuilder.Entity<RetroHistory>(entity =>
            {
                entity.HasKey(e => e.RetroId)
                    .HasName("PK_Retro");

                entity.ToTable("RetroHistory", "Pay");

                entity.Property(e => e.RetroId).HasColumnName("RetroID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReqPaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReqPaySeqID");

                entity.Property(e => e.RetroTypeId).HasColumnName("RetroTypeID");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.TotalHour).HasColumnType("numeric(4, 1)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RetroHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetroHistory_Employee");

                entity.HasOne(d => d.RetroType)
                    .WithMany(p => p.RetroHistories)
                    .HasForeignKey(d => d.RetroTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetroHistory_RetroType");
            });

            modelBuilder.Entity<RetroType>(entity =>
            {
                entity.ToTable("RetroType", "Pay");

                entity.Property(e => e.RetroTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("RetroTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<RightForm>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.FormId });

                entity.ToTable("RightForms", "Apps");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.RightForms)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RightForms_ApplicationForms");
            });

            modelBuilder.Entity<RightSubForm>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SubFormId });

                entity.ToTable("RightSubForms", "Apps");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.SubFormId).HasColumnName("SubFormID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.SubForm)
                    .WithMany(p => p.RightSubForms)
                    .HasForeignKey(d => d.SubFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RightSubForms_SubApplicationForms");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section", "Company");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Section_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Section_Department1");
            });

            modelBuilder.Entity<SettingTable>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("SettingTable", "Apps");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Descirption)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift", "Company");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DinnerEndTime)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DinnerStartTime)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LunchEndTime)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LunchStartTime)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_ID");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.Shifts)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shift_GroupCompany");
            });

            modelBuilder.Entity<StaffingAttendance>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.WorkDate, e.StaffingId });

                entity.ToTable("StaffingAttendance", "Times");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RoundIn).HasColumnType("datetime");

                entity.Property(e => e.RoundOut).HasColumnType("datetime");

                entity.Property(e => e.StaffingModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StaffingCompanyPayseq>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PaySeqId, e.GroupCompanyId });

                entity.ToTable("StaffingCompanyPayseq", "Pay");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.PaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<StaffingDailyAttendance>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.WorkDate, e.StaffingId, e.PunchIn, e.Created });

                entity.ToTable("StaffingDailyAttendance", "ThirdParty");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.PunchIn).HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CompanyLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PunchOut).HasColumnType("datetime");

                entity.Property(e => e.RoundIn).HasColumnType("datetime");

                entity.Property(e => e.RoundOut).HasColumnType("datetime");

                entity.Property(e => e.StaffingModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffingDailyAttendanceLog>(entity =>
            {
                entity.HasKey(e => new { e.LogDate, e.WorkDate, e.StaffingId, e.Count, e.PunchIn, e.Flag });

                entity.ToTable("StaffingDailyAttendance_Log", "ThirdParty");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkDate).HasColumnType("date");

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.PunchIn).HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActionFlag)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PunchOut).HasColumnType("datetime");

                entity.Property(e => e.RoundIn).HasColumnType("datetime");

                entity.Property(e => e.RoundOut).HasColumnType("datetime");

                entity.Property(e => e.StaffingModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffingEmployeeList>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.StaffingId, e.CompanyLocation, e.Created });

                entity.ToTable("StaffingEmployeeList", "ThirdParty");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.CompanyLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactRelation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCell)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StaffingModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TermDate).HasColumnType("date");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffingUser>(entity =>
            {
                entity.HasKey(e => e.SystemUserListId);

                entity.ToTable("StaffingUser", "Apps");

                entity.Property(e => e.SystemUserListId)
                    .ValueGeneratedNever()
                    .HasColumnName("SystemUserListID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.StaffingUsers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffingUser_Person");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.ToTable("StateProvince", "Base");

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((1))")
                    .HasComment("ISO standard code for countries and regions.");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubApplicationForm>(entity =>
            {
                entity.HasKey(e => e.SubFormId);

                entity.ToTable("SubApplicationForms", "Apps");

                entity.Property(e => e.SubFormId)
                    .HasColumnName("SubFormID")
                    .HasComment("Form list");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CaptionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.SubApplicationForms)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubApplicationForms_ApplicationForms");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("Survey", "MBO");

                entity.Property(e => e.SurveyId)
                    .HasColumnName("SurveyID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Eva1)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Eva2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Eva3)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Surveys)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survey_Company");
            });

            modelBuilder.Entity<SurveyEmployee>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.QuestionId });

                entity.ToTable("SurveyEmployee", "MBO");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("QuestionID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChoiceAnswer1).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChoiceAnswer2).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChoiceAnswer3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EssayAnswer1)
                    .HasMaxLength(3000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EssayAnswer2)
                    .HasMaxLength(3000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EssayAnswer3)
                    .HasMaxLength(3000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SurveyEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyEmployee_MBOEmployee");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyEmployees)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyEmployee_Question");
            });

            modelBuilder.Entity<SurveyEmployeeHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.QuestionId, e.Year });

                entity.ToTable("SurveyEmployeeHistory", "MBO");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("QuestionID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.ChoiceAnswer1).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChoiceAnswer2).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChoiceAnswer3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EssayAnswer1)
                    .HasMaxLength(3000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EssayAnswer2)
                    .HasMaxLength(3000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EssayAnswer3)
                    .HasMaxLength(3000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<SurveyReviewer>(entity =>
            {
                entity.HasKey(e => new { e.MbogroupId, e.EmployeeId });

                entity.ToTable("SurveyReviewer", "MBO");

                entity.Property(e => e.MbogroupId)
                    .HasColumnName("MBOGroupID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Mbogroup)
                    .WithMany(p => p.SurveyReviewers)
                    .HasForeignKey(d => d.MbogroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyReviewer_MBOGroup");
            });

            modelBuilder.Entity<SystemLogInOut>(entity =>
            {
                entity.HasKey(e => new { e.SystemUserId, e.LogInOut, e.Created })
                    .HasName("PK_SystemLogInOut_1");

                entity.ToTable("SystemLogInOut", "Log");

                entity.Property(e => e.SystemUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SystemUserID");

                entity.Property(e => e.LogInOut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VersionBuild)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionMajor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionMinor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRevision)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasKey(e => e.SystemUserListId);

                entity.ToTable("SystemUsers", "Apps");

                entity.Property(e => e.SystemUserListId).HasColumnName("SystemUserListID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_Person");

                entity.ToTable("tEmployee", "Test");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusTypeId).HasColumnName("MaritalStatusTypeID");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.HasOne(d => d.MaritalStatusType)
                    .WithMany(p => p.TEmployees)
                    .HasForeignKey(d => d.MaritalStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_MartitalStatusType");
            });

            modelBuilder.Entity<TGenderType>(entity =>
            {
                entity.HasKey(e => e.GenderTypeId)
                    .HasName("PK_GenderType");

                entity.ToTable("tGenderType", "Test");

                entity.Property(e => e.GenderTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("GenderTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<TPersonPhone>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.PhoneNumber })
                    .HasName("PK_PersonPhone");

                entity.ToTable("tPersonPhone", "Test");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TPersonPhones)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonPhone_Person");

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.TPersonPhones)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .HasConstraintName("FK_PersonPhone_PhoneType");
            });

            modelBuilder.Entity<TPhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeId)
                    .HasName("PK_PhoneType");

                entity.ToTable("tPhoneType", "Test");

                entity.Property(e => e.PhoneTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("PhoneTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<TerminalList>(entity =>
            {
                entity.HasKey(e => e.TerminalId);

                entity.ToTable("TerminalLists", "Company");

                entity.Property(e => e.TerminalId)
                    .ValueGeneratedNever()
                    .HasColumnName("TerminalID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatredBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.TerminalGroupName).HasMaxLength(50);

                entity.Property(e => e.TerminalName).HasMaxLength(50);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.A);

                entity.ToTable("test", "Test");

                entity.Property(e => e.A)
                    .ValueGeneratedNever()
                    .HasColumnName("a");

                entity.Property(e => e.B).HasColumnName("b");
            });

            modelBuilder.Entity<UnitPayseq>(entity =>
            {
                entity.HasKey(e => new { e.PayweekId, e.PaySeqId });

                entity.ToTable("UnitPayseq", "Pay");

                entity.Property(e => e.PayweekId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PayweekID");

                entity.Property(e => e.PaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.WeekEnd).HasColumnType("date");

                entity.Property(e => e.WeekStart).HasColumnType("date");

                entity.HasOne(d => d.PaySeq)
                    .WithMany(p => p.UnitPayseqs)
                    .HasForeignKey(d => d.PaySeqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitPayseq_PaySeq");
            });

            modelBuilder.Entity<UserGroupCompany>(entity =>
            {
                entity.HasKey(e => new { e.SystemUserListId, e.GroupCompanyId });

                entity.ToTable("UserGroupCompany", "Apps");

                entity.Property(e => e.SystemUserListId).HasColumnName("SystemUserListID");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.GroupCompany)
                    .WithMany(p => p.UserGroupCompanies)
                    .HasForeignKey(d => d.GroupCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroupCompany_GroupCompany");

                entity.HasOne(d => d.SystemUserList)
                    .WithMany(p => p.UserGroupCompanies)
                    .HasForeignKey(d => d.SystemUserListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroupCompany_SystemUsers");
            });

            modelBuilder.Entity<UserPassword>(entity =>
            {
                entity.HasKey(e => new { e.SystemUserListId, e.UserPw, e.Created });

                entity.ToTable("UserPassword", "Apps");

                entity.Property(e => e.SystemUserListId).HasColumnName("SystemUserListID");

                entity.Property(e => e.UserPw)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.SystemUserList)
                    .WithMany(p => p.UserPasswords)
                    .HasForeignKey(d => d.SystemUserListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPassword_SystemUsers");
            });

            modelBuilder.Entity<VAttendanceByEmpId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAttendanceByEmpID");

                entity.Property(e => e.ConfirmIn).HasColumnType("datetime");

                entity.Property(e => e.ConfirmOut).HasColumnType("datetime");

                entity.Property(e => e.CreateLocation)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ExceptionTypeId).HasColumnName("ExceptionTypeID");

                entity.Property(e => e.PunchIn).HasColumnType("datetime");

                entity.Property(e => e.PunchOut).HasColumnType("datetime");

                entity.Property(e => e.WorkDate).HasColumnType("date");
            });

            modelBuilder.Entity<VCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompany");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyPayTypeCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTypeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodTypeId).HasColumnName("PayPeriodTypeID");

                entity.Property(e => e.RegisterDate).HasColumnType("date");

                entity.Property(e => e.TerminateDate).HasColumnType("date");
            });

            modelBuilder.Entity<VCompanyHistoryByEmpId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompanyHistoryByEmpID");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.RetiredTypeId).HasColumnName("RetiredTypeID");
            });

            modelBuilder.Entity<VCompanyPaySeq>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompanyPaySeq");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.PaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.PayYear)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SeqEnd).HasColumnType("date");

                entity.Property(e => e.SeqStart).HasColumnType("date");
            });

            modelBuilder.Entity<VDailyAttendanceCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDailyAttendanceCount");

                entity.Property(e => e.Man).HasColumnName("MAN");

                entity.Property(e => e.Ymd)
                    .HasColumnType("date")
                    .HasColumnName("YMD");
            });

            modelBuilder.Entity<VDailyStatusLogFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDailyStatusLogFull");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.WorkDate).HasColumnType("date");
            });

            modelBuilder.Entity<VDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDepartment");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentTypeId).HasColumnName("DepartmentTypeID");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEmployeeBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeBank");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankTypeId).HasColumnName("BankTypeID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EmployeeAccountId).HasColumnName("EmployeeAccountID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.RoutingNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEmployeeCommentByEmployeeId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeCommentByEmployeeID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<VEmployeeCompensation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeCompensation");

                entity.Property(e => e.AdditionalPayAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalPayRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BillingPayRate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.EffectivePaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EffectivePaySeqID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.PayPeriodTypeId).HasColumnName("PayPeriodTypeID");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.PeriodType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEmployeeDailyAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDailyAttendance");

                entity.Property(e => e.AliasName).HasMaxLength(50);

                entity.Property(e => e.BillingPayRate).HasColumnType("money");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DaysOfWeek).HasMaxLength(30);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MarkupRate).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftTime)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StaffingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StaffingID");

                entity.Property(e => e.WorkDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkHour).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<VEmployeeDemographic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDemographic");

                entity.Property(e => e.AliasName).HasMaxLength(50);

                entity.Property(e => e.Citizenship)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DriversLicense)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GenderTypeId).HasColumnName("GenderTypeID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusTypeId).HasColumnName("MaritalStatusTypeID");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.VisaStatusTypeId).HasColumnName("VisaStatusTypeID");
            });

            modelBuilder.Entity<VEmployeeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDetail");

                entity.Property(e => e.Citizenship)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DriversLicense)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TerminatedReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEmployeeFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeFull");

                entity.Property(e => e.AdditionalPayAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalPayRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BillingPayRate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.RetiredTypeId).HasColumnName("RetiredTypeID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            });

            modelBuilder.Entity<VEmployeeInsuranceSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeInsuranceSummary");

                entity.Property(e => e.Detail)
                    .HasMaxLength(92)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.InsuranceType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");
            });

            modelBuilder.Entity<VEmployeeListForNitgen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeListForNitgen");

                entity.Property(e => e.AliasName).HasMaxLength(50);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RetireDate).HasColumnType("date");
            });

            modelBuilder.Entity<VEmployeeListforAme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeListforAMES");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEmployeeScheduleFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeScheduleFull");

                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.GroupCompany)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.GrpCompLocId).HasColumnName("GrpCompLocID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            });

            modelBuilder.Entity<VEmployeeStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeStatus");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.RetireDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TerminatedReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VGroupCompanyLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGroupCompanyLocation");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCompanyId).HasColumnName("GroupCompanyID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vImage");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ImageText)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ImageTypeId).HasColumnName("ImageTypeID");
            });

            modelBuilder.Entity<VLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLocation");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPayApplySchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayApplySchedule");

                entity.Property(e => e.AdditionalPayAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalPayRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BillingPayRate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EffectivePaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EffectivePaySeqID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ExpiredPaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExpiredPaySeqID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.OvertimeRatio).HasColumnType("numeric(2, 1)");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.SeqEnd).HasColumnType("date");

                entity.Property(e => e.SeqStart).HasColumnType("date");
            });

            modelBuilder.Entity<VPayApplyScheduleHourly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayApplyScheduleHourly");

                entity.Property(e => e.AdditionalPayAmount).HasColumnType("money");

                entity.Property(e => e.AdditionalPayRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.BillingPayRate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EffectivePaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EffectivePaySeqID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.ExpiredPaySeqId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExpiredPaySeqID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OvertimeRatio).HasColumnType("numeric(2, 1)");

                entity.Property(e => e.PayRate).HasColumnType("money");

                entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

                entity.Property(e => e.SeqEnd).HasColumnType("date");

                entity.Property(e => e.SeqStart).HasColumnType("date");
            });

            modelBuilder.Entity<VRetroEmployeeList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRetroEmployeeList");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.PaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PaySeqID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReqPaySeqId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReqPaySeqID");

                entity.Property(e => e.RetroAmount).HasColumnType("money");

                entity.Property(e => e.RetroDetailId).HasColumnName("RetroDetailID");

                entity.Property(e => e.RetroId).HasColumnName("RetroID");

                entity.Property(e => e.RetroTypeId).HasColumnName("RetroTypeID");

                entity.Property(e => e.SeqEnd).HasColumnType("date");

                entity.Property(e => e.SeqStart).HasColumnType("date");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.TotalHour).HasColumnType("numeric(4, 1)");
            });

            modelBuilder.Entity<VSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSection");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SectionID");

                entity.Property(e => e.SectionId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Section_ID");
            });

            modelBuilder.Entity<WarningType>(entity =>
            {
                entity.ToTable("WarningType", "Times");

                entity.Property(e => e.WarningTypeId).HasColumnName("WarningTypeID");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
