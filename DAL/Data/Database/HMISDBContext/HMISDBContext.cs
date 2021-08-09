using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Data.Database.Tables;

#nullable disable

namespace DAL.Data.Database.HMISDBContext
{
    public partial class HMISDBContext : DbContext
    {
        public HMISDBContext()
        {
        }

        public HMISDBContext(DbContextOptions<HMISDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<FieldAttribute> FieldAttributes { get; set; }
        public virtual DbSet<HealthFacilityDetail> HealthFacilityDetails { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<Patient_MRNO> Patient_MRNOs { get; set; }
        public virtual DbSet<school_vaccination> school_vaccinations { get; set; }
        public virtual DbSet<tbl_HealthFacilityDetail> tbl_HealthFacilityDetails { get; set; }
        public virtual DbSet<tbl_PatientRegistration> tbl_PatientRegistrations { get; set; }
        public virtual DbSet<tbl_baseline> tbl_baselines { get; set; }
        public virtual DbSet<tbl_baseline_status> tbl_baseline_statuses { get; set; }
        public virtual DbSet<tbl_batch> tbl_batches { get; set; }
        public virtual DbSet<tbl_batch_sample> tbl_batch_samples { get; set; }
        public virtual DbSet<tbl_bp_normalization> tbl_bp_normalizations { get; set; }
        public virtual DbSet<tbl_callcenter> tbl_callcenters { get; set; }
        public virtual DbSet<tbl_callcenter_stat> tbl_callcenter_stats { get; set; }
        public virtual DbSet<tbl_cbc_parameter> tbl_cbc_parameters { get; set; }
        public virtual DbSet<tbl_dispatch> tbl_dispatches { get; set; }
        public virtual DbSet<tbl_drug_interaction_med_sec> tbl_drug_interaction_med_secs { get; set; }
        public virtual DbSet<tbl_event> tbl_events { get; set; }
        public virtual DbSet<tbl_event_indicator> tbl_event_indicators { get; set; }
        public virtual DbSet<tbl_family_assesment> tbl_family_assesments { get; set; }
        public virtual DbSet<tbl_final_stock> tbl_final_stocks { get; set; }
        public virtual DbSet<tbl_health_facility_type> tbl_health_facility_types { get; set; }
        public virtual DbSet<tbl_health_facilty_category> tbl_health_facilty_categories { get; set; }
        public virtual DbSet<tbl_indicator> tbl_indicators { get; set; }
        public virtual DbSet<tbl_indicator_cat> tbl_indicator_cats { get; set; }
        public virtual DbSet<tbl_lab_action> tbl_lab_actions { get; set; }
        public virtual DbSet<tbl_lab_batch> tbl_lab_batches { get; set; }
        public virtual DbSet<tbl_lab_batch_sample> tbl_lab_batch_samples { get; set; }
        public virtual DbSet<tbl_lab_result> tbl_lab_results { get; set; }
        public virtual DbSet<tbl_lab_sample> tbl_lab_samples { get; set; }
        public virtual DbSet<tbl_labortary> tbl_labortaries { get; set; }
        public virtual DbSet<tbl_marital_status> tbl_marital_statuses { get; set; }
        public virtual DbSet<tbl_med_delivery_log> tbl_med_delivery_logs { get; set; }
        public virtual DbSet<tbl_medicine_disbursement_old_regime> tbl_medicine_disbursement_old_regimes { get; set; }
        public virtual DbSet<tbl_micro_screening> tbl_micro_screenings { get; set; }
        public virtual DbSet<tbl_new_regime_med_log> tbl_new_regime_med_logs { get; set; }
        public virtual DbSet<tbl_new_regime_medicine> tbl_new_regime_medicines { get; set; }
        public virtual DbSet<tbl_new_regime_stock_log> tbl_new_regime_stock_logs { get; set; }
        public virtual DbSet<tbl_next_of_kin> tbl_next_of_kins { get; set; }
        public virtual DbSet<tbl_occupation> tbl_occupations { get; set; }
        public virtual DbSet<tbl_patient_assessment> tbl_patient_assessments { get; set; }
        public virtual DbSet<tbl_patient_consignment_number> tbl_patient_consignment_numbers { get; set; }
        public virtual DbSet<tbl_patient_factor> tbl_patient_factors { get; set; }
        public virtual DbSet<tbl_patient_history> tbl_patient_histories { get; set; }
        public virtual DbSet<tbl_patient_refer> tbl_patient_refers { get; set; }
        public virtual DbSet<tbl_patient_refer_receive> tbl_patient_refer_receives { get; set; }
        public virtual DbSet<tbl_patient_refer_receive_history> tbl_patient_refer_receive_histories { get; set; }
        public virtual DbSet<tbl_patient_stage> tbl_patient_stages { get; set; }
        public virtual DbSet<tbl_patient_transfer> tbl_patient_transfers { get; set; }
        public virtual DbSet<tbl_patient_vital> tbl_patient_vitals { get; set; }
        public virtual DbSet<tbl_patientvaccination> tbl_patientvaccinations { get; set; }
        public virtual DbSet<tbl_private_lab_result> tbl_private_lab_results { get; set; }
        public virtual DbSet<tbl_qualification> tbl_qualifications { get; set; }
        public virtual DbSet<tbl_refer_district> tbl_refer_districts { get; set; }
        public virtual DbSet<tbl_refer_hospital> tbl_refer_hospitals { get; set; }
        public virtual DbSet<tbl_refer_province> tbl_refer_provinces { get; set; }
        public virtual DbSet<tbl_refer_tehsil> tbl_refer_tehsils { get; set; }
        public virtual DbSet<tbl_renal_function> tbl_renal_functions { get; set; }
        public virtual DbSet<tbl_sample> tbl_samples { get; set; }
        public virtual DbSet<tbl_screening> tbl_screenings { get; set; }
        public virtual DbSet<tbl_sms_log> tbl_sms_logs { get; set; }
        public virtual DbSet<tbl_stock> tbl_stocks { get; set; }
        public virtual DbSet<tbl_svr_form_datum> tbl_svr_form_data { get; set; }
        public virtual DbSet<tbl_tcs_batch> tbl_tcs_batches { get; set; }
        public virtual DbSet<tbl_tcs_batch_patient> tbl_tcs_batch_patients { get; set; }
        public virtual DbSet<tbl_temporary_result_upload> tbl_temporary_result_uploads { get; set; }
        public virtual DbSet<tbl_ticket> tbl_tickets { get; set; }
        public virtual DbSet<tbl_treatment> tbl_treatments { get; set; }
        public virtual DbSet<tbl_uc> tbl_ucs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Initial Catalog=HM;user id=arslan;password=abcd@1234;Data Source=172.16.15.5");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.CNIC).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.DeletedBy).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EndRange).HasMaxLength(50);

                entity.Property(e => e.HashConfirmPassword).HasMaxLength(120);

                entity.Property(e => e.HealthFacilityCode).HasMaxLength(200);

                entity.Property(e => e.IMEI).HasMaxLength(50);

                entity.Property(e => e.Identifer).HasMaxLength(100);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.RawConfirmPassword).HasMaxLength(120);

                entity.Property(e => e.StartRange).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FieldAttribute>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.OnChangefunction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OnClickfunction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Onblurfunction)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthFacilityDetail>(entity =>
            {
                entity.Property(e => e.Created_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Patient_MRNO>(entity =>
            {
                entity.ToTable("Patient_MRNO");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MRNO).HasMaxLength(250);
            });

            modelBuilder.Entity<school_vaccination>(entity =>
            {
                entity.ToTable("school_vaccination");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.alt_contact_number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.cnic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.cnic_not_available)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.cnic_status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.contact_number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.districts_referral)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.dob).HasColumnType("date");

                entity.Property(e => e.first_name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.health_type)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HW')");

                entity.Property(e => e.is_reception).HasDefaultValueSql("((0))");

                entity.Property(e => e.last_name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.marital_status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.patient_class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.pcr_option)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.pcr_type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.reg_no)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.rel_contact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.school_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.school_registration_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.spouse_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.tehsil_referral_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.test_required)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.uc_number)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_HealthFacilityDetail>(entity =>
            {
                entity.Property(e => e.Created_Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_PatientRegistration>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CNIC)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CNICStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedVaccination_HBV)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DOB).HasColumnType("datetime");

                entity.Property(e => e.EntryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HealthFacilityCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MRNO).HasMaxLength(50);

                entity.Property(e => e.MartialStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PCRConfirmation_HBV)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PCRConfirmation_HCV)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PatientType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Previous_HBV)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Previous_HCV)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserHealthFacilityCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.dod_date).HasColumnType("date");

                entity.Property(e => e.finger_print1).IsUnicode(false);

                entity.Property(e => e.finger_print2).IsUnicode(false);

                entity.Property(e => e.is_blood_bank_patient).HasDefaultValueSql("((0))");

                entity.Property(e => e.lost_followup_id).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_baseline>(entity =>
            {
                entity.ToTable("tbl_baseline");

                entity.Property(e => e.Ascites).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.counselling).HasDefaultValueSql("((0))");

                entity.Property(e => e.deferred).HasDefaultValueSql("((0))");

                entity.Property(e => e.discharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.genotyping)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.hbv_medicine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.hbv_pcr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.hbv_viral_load).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.hcv_medicine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.hcv_pcr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.hcv_viral_load).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.is_hbv_medicine).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_hcv_medicine).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_skip).HasDefaultValueSql("((0))");

                entity.Property(e => e.liver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('normal')");

                entity.Property(e => e.prescribe_medicine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.referral_pkli).HasDefaultValueSql("((0))");

                entity.Property(e => e.spleen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('No Splenomegaly')");

                entity.Property(e => e.vaccination).HasDefaultValueSql("((0))");

                entity.Property(e => e.vaccination_option)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_baseline_status>(entity =>
            {
                entity.Property(e => e.status_name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_batch>(entity =>
            {
                entity.ToTable("tbl_batch");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.bactch_number)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_batch_sample>(entity =>
            {
                entity.HasIndex(e => e.sample_number, "sample_number");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_bp_normalization>(entity =>
            {
                entity.ToTable("tbl_bp_normalization");

                entity.HasIndex(e => e.baseline_type, "baseline_type");

                entity.HasIndex(e => e.pid, "pid");

                entity.Property(e => e.baseline_type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HBV')");
            });

            modelBuilder.Entity<tbl_callcenter>(entity =>
            {
                entity.ToTable("tbl_callcenter");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.address)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.alt_phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.contact_phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.created_b)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.fathername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.lab_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.land_mark)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.monthly_income)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.mrn_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.no_cnic_reason)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.self_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.test_date).HasColumnType("date");
            });

            modelBuilder.Entity<tbl_callcenter_stat>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.OriginalDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_cbc_parameter>(entity =>
            {
                entity.ToTable("tbl_cbc_parameter");

                entity.Property(e => e.apri)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.baseline_type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HBV')");

                entity.Property(e => e.follow_up_no).HasDefaultValueSql("('0')");

                entity.Property(e => e.lab_name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.other_lab_name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.pcr_result)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.result_type)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_dispatch>(entity =>
            {
                entity.ToTable("tbl_dispatch");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.batchno)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.cnic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.consignment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.contactno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.courier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.organization)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_drug_interaction_med_sec>(entity =>
            {
                entity.ToTable("tbl_drug_interaction_med_sec");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.admin_followup_date).HasColumnType("datetime");

                entity.Property(e => e.baseline_type)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HBV')");

                entity.Property(e => e.disburse_3_mnth_dose).HasDefaultValueSql("((0))");

                entity.Property(e => e.disburse_6_mnth_dose).HasDefaultValueSql("((0))");

                entity.Property(e => e.drug_interaction).HasDefaultValueSql("((0))");

                entity.Property(e => e.enticavir).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_admin_follow_up).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_demote).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_duplicate)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.is_imported_data).HasDefaultValueSql("((0))");

                entity.Property(e => e.sample_recommended).HasDefaultValueSql("((0))");

                entity.Property(e => e.sample_svr_flag)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sd_pack).HasDefaultValueSql("((0))");

                entity.Property(e => e.sdr_pack).HasDefaultValueSql("((0))");

                entity.Property(e => e.sr_pack).HasDefaultValueSql("((0))");

                entity.Property(e => e.telbuvidine).HasDefaultValueSql("((0))");

                entity.Property(e => e.tenofovir).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_event>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.description).IsUnicode(false);

                entity.Property(e => e.event_name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.industry)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_event_indicator>(entity =>
            {
                entity.ToTable("tbl_event_indicator");

                entity.Property(e => e.IndicatorID)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_family_assesment>(entity =>
            {
                entity.ToTable("tbl_family_assesment");

                entity.Property(e => e.CNIC)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DOB).HasColumnType("date");

                entity.Property(e => e.Relation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.created).HasPrecision(0);

                entity.Property(e => e.mrn_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.pcr_confirmation_hbv).HasDefaultValueSql("((0))");

                entity.Property(e => e.pcr_confirmation_hcv).HasDefaultValueSql("((0))");

                entity.Property(e => e.previous_hbv_test).HasDefaultValueSql("((0))");

                entity.Property(e => e.updated).HasPrecision(0);
            });

            modelBuilder.Entity<tbl_final_stock>(entity =>
            {
                entity.ToTable("tbl_final_stock");

                entity.HasIndex(e => e.Hospital_ID, "hospital_id");

                entity.HasIndex(e => e.medicine_id, "medicine_id");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DISTRICTS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HEALTHCARE_FACILITY)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.remaining_stock_2).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_health_facility_type>(entity =>
            {
                entity.ToTable("tbl_health_facility_type");

                entity.Property(e => e.health_facility_name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_health_facilty_category>(entity =>
            {
                entity.ToTable("tbl_health_facilty_category");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_indicator>(entity =>
            {
                entity.ToTable("tbl_indicator");

                entity.Property(e => e.IndicatorID)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_indicator_cat>(entity =>
            {
                entity.ToTable("tbl_indicator_cat");

                entity.Property(e => e.name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_lab_action>(entity =>
            {
                entity.ToTable("tbl_lab_action");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_lab_batch>(entity =>
            {
                entity.ToTable("tbl_lab_batch");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.UpdationTime).HasColumnType("datetime");

                entity.Property(e => e.assigned_to).HasDefaultValueSql("((0))");

                entity.Property(e => e.batch_number)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_lab_batch_sample>(entity =>
            {
                entity.ToTable("tbl_lab_batch_sample");

                entity.HasIndex(e => e.batch_id, "batch_id");

                entity.HasIndex(e => e.sample_id, "sample_id");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_lab_result>(entity =>
            {
                entity.ToTable("tbl_lab_result");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.hbv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.hcv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.is_hbv_detected)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.is_hcv_detected)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.test_required)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_lab_sample>(entity =>
            {
                entity.ToTable("tbl_lab_sample");

                entity.HasIndex(e => e.id, "id");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.batch_number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.is_sample_svr).HasDefaultValueSql("((0))");

                entity.Property(e => e.sample_number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.test_type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.total_duplicate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_labortary>(entity =>
            {
                entity.ToTable("tbl_labortary");

                entity.Property(e => e.CREATED_BY)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CREATION_DATE)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NAME)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UPDATION_DATE)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UPDTED_BY)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_marital_status>(entity =>
            {
                entity.ToTable("tbl_marital_status");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_med_delivery_log>(entity =>
            {
                entity.ToTable("tbl_med_delivery_log");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.booking_date).HasPrecision(0);

                entity.Property(e => e.consignee)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.delivered_tcs_date)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.mo_deliver).HasDefaultValueSql("((0))");

                entity.Property(e => e.mo_status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.prescription_no)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.received_by)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_medicine_disbursement_old_regime>(entity =>
            {
                entity.ToTable("tbl_medicine_disbursement_old_regime");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.created)
                    .HasPrecision(0)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.demote_status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_micro_screening>(entity =>
            {
                entity.ToTable("tbl_micro_screening");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.activity_type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('micro')");

                entity.Property(e => e.address).HasColumnType("text");

                entity.Property(e => e.alt_contact_number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.api_district_name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.cnic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.cnic_not_available)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.contact_number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.department)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.districts_referral)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.dob).HasColumnType("date");

                entity.Property(e => e.first_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.frm_data_plug).HasDefaultValueSql("((0))");

                entity.Property(e => e.health_type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HW')");

                entity.Property(e => e.imei_no)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.is_already_vaccinated).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_first_vaccine).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_household_info).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_pat_reg_in_emr).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_reception).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_sample_add).HasDefaultValueSql("((0))");

                entity.Property(e => e.last_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.marital_status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.mrn_no)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.patient_class)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.pcr_option)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.pcr_type)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.reg_no)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.rel_contact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sample_id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.school_name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.school_registration_no)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.spouse_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.tehsil_name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.tehsil_referral_name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.test_required)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.uc_name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.uc_number)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_new_regime_med_log>(entity =>
            {
                entity.ToTable("tbl_new_regime_med_log");

                entity.HasIndex(e => e.PatientID, "PatientID");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.baseline_type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HBV')");

                entity.Property(e => e.is_demote).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_new_regime_medicine>(entity =>
            {
                entity.ToTable("tbl_new_regime_medicine");

                entity.Property(e => e.medicine_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.medicine_type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HBV')");
            });

            modelBuilder.Entity<tbl_new_regime_stock_log>(entity =>
            {
                entity.ToTable("tbl_new_regime_stock_log");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_next_of_kin>(entity =>
            {
                entity.ToTable("tbl_next_of_kin");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_occupation>(entity =>
            {
                entity.ToTable("tbl_occupation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_patient_assessment>(entity =>
            {
                entity.ToTable("tbl_patient_assessment");

                entity.HasIndex(e => e.PatientID, "PatientID");

                entity.HasIndex(e => e.created, "created");

                entity.HasIndex(e => e.user_id, "user_id");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.blood_bank)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.blood_transfusion_when)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.counselling).HasDefaultValueSql("((0))");

                entity.Property(e => e.dental_clinic)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.is_legacy_svr).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_new_patient).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_sample_svr).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_temporary_delete).HasDefaultValueSql("((0))");

                entity.Property(e => e.note).IsUnicode(false);

                entity.Property(e => e.pcr).HasDefaultValueSql("((0))");

                entity.Property(e => e.pcr_option)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.raPatientID_testing).HasDefaultValueSql("((0))");

                entity.Property(e => e.surgery_type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.surgery_when)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.vac_dose_date1).HasColumnType("datetime");

                entity.Property(e => e.vac_dose_date2).HasColumnType("datetime");

                entity.Property(e => e.vaccination).HasDefaultValueSql("((0))");

                entity.Property(e => e.vacination).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_patient_consignment_number>(entity =>
            {
                entity.ToTable("tbl_patient_consignment_number");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.consignment_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_patient_factor>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(500);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.cFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.dFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.eFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.fFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.xFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.yFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.zFactor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_patient_history>(entity =>
            {
                entity.ToTable("tbl_patient_history");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_patient_refer>(entity =>
            {
                entity.ToTable("tbl_patient_refer");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.action_date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.actiondate).HasColumnType("datetime");

                entity.Property(e => e.patient_stage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.patient_type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.refer_reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.refer_request_date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.refer_requestdate).HasColumnType("datetime");

                entity.Property(e => e.refer_status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pending')");
            });

            modelBuilder.Entity<tbl_patient_refer_receive>(entity =>
            {
                entity.ToTable("tbl_patient_refer_receive");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.contact_no_self)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.dob)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.father_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.first_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.last_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.mrn_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.receive_date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.refer_reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.refer_status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('pending')");

                entity.Property(e => e.req_dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.req_hospital)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.self_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_patient_refer_receive_history>(entity =>
            {
                entity.ToTable("tbl_patient_refer_receive_history");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.cnic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.diagnosis)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.investigation_mo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.investigation_nurse)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.medicine)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.symptoms)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_patient_stage>(entity =>
            {
                entity.ToTable("tbl_patient_stage");

                entity.HasIndex(e => e.id, "id");

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.stage_status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tbl_patient_transfer>(entity =>
            {
                entity.ToTable("tbl_patient_transfer");

                entity.Property(e => e.Actiondate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.Vaccination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.action_date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.hbv_medicine_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.hcv_medicine_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.patient_stage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.patient_type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.screening_hbv)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.screening_hcv)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.transfer_in_facility_name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.transfer_reason).HasColumnType("text");

                entity.Property(e => e.transfer_request_date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.transfer_requestdate).HasColumnType("datetime");

                entity.Property(e => e.transfer_status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<tbl_patient_vital>(entity =>
            {
                entity.ToTable("tbl_patient_vital");

                entity.HasIndex(e => e.PatientID, "PatientID");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.bp_diastolic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.bp_systolic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.pulse).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.temperature).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<tbl_patientvaccination>(entity =>
            {
                entity.ToTable("tbl_patientvaccination");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dosedate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.entry_type)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_private_lab_result>(entity =>
            {
                entity.ToTable("tbl_private_lab_result");

                entity.HasIndex(e => e.PatientID, "PatientID");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.hbv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.hcv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.is_hbv_detected)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.is_hcv_detected)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.lab_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.result_type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.test_required)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_qualification>(entity =>
            {
                entity.ToTable("tbl_qualification");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_refer_district>(entity =>
            {
                entity.ToTable("tbl_refer_district");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.district_code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.district_name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_refer_hospital>(entity =>
            {
                entity.ToTable("tbl_refer_hospital");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.city)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.clinic_address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.clinic_code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.clinic_lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.clinic_lon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.clinic_name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.clinic_type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.facility_type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('active')");
            });

            modelBuilder.Entity<tbl_refer_province>(entity =>
            {
                entity.ToTable("tbl_refer_province");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_refer_tehsil>(entity =>
            {
                entity.ToTable("tbl_refer_tehsil");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.teshil_code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_renal_function>(entity =>
            {
                entity.ToTable("tbl_renal_function");

                entity.Property(e => e.baseline_type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('HBV')");

                entity.Property(e => e.creatinie).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<tbl_sample>(entity =>
            {
                entity.ToTable("tbl_sample");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.is_dispatch).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_lab_batch).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_reception).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_sample_svr).HasDefaultValueSql("((0))");

                entity.Property(e => e.number)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_screening>(entity =>
            {
                entity.ToTable("tbl_screening");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.address_available).HasDefaultValueSql("((1))");

                entity.Property(e => e.contact_no_self)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.father_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.mrn_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.next_of_kin_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.no_cnic_reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.old_reg_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.other_contactno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.patient_dob).HasColumnType("date");

                entity.Property(e => e.patient_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.patient_type)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('New Patient')");

                entity.Property(e => e.postal_address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.reg_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.relation_contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.self_cnic)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_sms_log>(entity =>
            {
                entity.ToTable("tbl_sms_log");

                entity.Property(e => e.created_date).HasPrecision(0);

                entity.Property(e => e.message)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.monbile_no)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.mrn_no)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.response)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.sms_type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_stock>(entity =>
            {
                entity.ToTable("tbl_stock");

                entity.HasIndex(e => e.hospital_id, "hospital_id");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbl_svr_form_datum>(entity =>
            {
                entity.HasIndex(e => e.PatientID, "PatientID");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.etr_pcr_labname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.etr_pcr_labname_other)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.gap_btw_treatment).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_etr_pcr).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_new_regime_pat).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_pat_achieve_etr).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_pat_achieve_svr).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_svr_pcr).HasDefaultValueSql("((0))");

                entity.Property(e => e.sample_recommended).HasDefaultValueSql("((0))");

                entity.Property(e => e.sample_tag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.svr_pcr_labname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.svr_pcr_labname_other)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_tcs_batch>(entity =>
            {
                entity.ToTable("tbl_tcs_batch");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.batch_number)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.batch_type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.hfc_address).IsUnicode(false);
            });

            modelBuilder.Entity<tbl_tcs_batch_patient>(entity =>
            {
                entity.ToTable("tbl_tcs_batch_patient");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.batch_id)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_temporary_result_upload>(entity =>
            {
                entity.ToTable("tbl_temporary_result_upload");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.hbv_viral_load)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.hcv_viral_load)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.is_batch_count_matched).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_found).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_svr_sample)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.result_hbv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.result_hcv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sample_no)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.test_required)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_ticket>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ticket_id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_treatment>(entity =>
            {
                entity.ToTable("tbl_treatment");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(500);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");

                entity.Property(e => e.hbv_medicine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.hcv_medicine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.is_hbv_medicine).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_hbv_test).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_hcv_medicine).HasDefaultValueSql("((0))");

                entity.Property(e => e.is_hcv_test).HasDefaultValueSql("((0))");

                entity.Property(e => e.pcr)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.vaccination_option)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Skip')");
            });

            modelBuilder.Entity<tbl_uc>(entity =>
            {
                entity.ToTable("tbl_uc");

                entity.Property(e => e.is_active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.uc_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
