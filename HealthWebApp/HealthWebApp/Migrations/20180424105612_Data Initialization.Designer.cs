using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HealthWebApp.Data;
using HealthWebApp.Data.EntityModel.Household;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.EntityModel.PhilHealthFolder;

namespace HealthWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180424105612_Data Initialization")]
    partial class DataInitialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Barangay", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityMunicipalityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityMunicipalityId");

                    b.ToTable("Barangay");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.BarangayOfficial", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("BarangayId");

                    b.Property<int>("DesignationId");

                    b.Property<long>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("BarangayId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("PersonId");

                    b.ToTable("BarangayOfficial");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.CityMunicipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Designation");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.PhilArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PhilArea");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PhilAreaId");

                    b.HasKey("Id");

                    b.HasIndex("PhilAreaId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("EmployeeId");

                    b.Property<string>("LongName");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Household.Family", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Family");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Household.HouseholdMember", b =>
                {
                    b.Property<long>("PersonId");

                    b.Property<long>("HouseholdProfileId");

                    b.Property<int>("RelationToHead");

                    b.HasKey("PersonId");

                    b.HasIndex("HouseholdProfileId");

                    b.ToTable("HouseholdMember");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Household.HouseholdProfile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<long>("BarangayId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateTimeLastUpdated");

                    b.Property<long>("EmployeeId");

                    b.Property<string>("Note");

                    b.Property<string>("ProfileId");

                    b.HasKey("Id");

                    b.HasIndex("BarangayId");

                    b.ToTable("HouseholdProfile");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.NameTitle", b =>
                {
                    b.Property<int>("NameTitleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("NameTitleId");

                    b.ToTable("NameTitle");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CivilStatus");

                    b.Property<string>("ContactNumber");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateTimeLastUpdated");

                    b.Property<string>("EmailAddress");

                    b.Property<long>("EmployeeId");

                    b.Property<int>("ExtensionName");

                    b.Property<long?>("FamilyId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("NameTitleId");

                    b.Property<bool>("PersonConsent");

                    b.Property<int>("ReligionId");

                    b.Property<int>("Sex");

                    b.Property<int>("WorkId");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.HasIndex("NameTitleId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("WorkId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.PhilHealthFolder.PhilHealth", b =>
                {
                    b.Property<long>("PersonId");

                    b.Property<int>("Category");

                    b.Property<DateTime>("DateAssigned");

                    b.Property<long>("EmployeeId");

                    b.Property<int>("EmployerType");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("Identification");

                    b.Property<int>("Individual");

                    b.Property<bool>("Lifetime");

                    b.Property<int>("Sponsored");

                    b.Property<int>("StatusType");

                    b.HasKey("PersonId");

                    b.ToTable("PhilHealth");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Religion", b =>
                {
                    b.Property<int>("ReligionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ReligionId");

                    b.ToTable("Religion");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("WorkId");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("HealthWebApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Barangay", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.CityMunicipality", "CityMunicipality")
                        .WithMany("Barangays")
                        .HasForeignKey("CityMunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.BarangayOfficial", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.Barangay", "Barangay")
                        .WithMany("BarangayOfficials")
                        .HasForeignKey("BarangayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.Designation", "Position")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp.Data.EntityModel.Person", "Officer")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.CityMunicipality", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.Province", "Province")
                        .WithMany("CityMunicipalities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Province", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.Region", "Region")
                        .WithMany("Provinces")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Barangays.Region", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.PhilArea", "PhilArea")
                        .WithMany("Regions")
                        .HasForeignKey("PhilAreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Household.HouseholdMember", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Household.HouseholdProfile", "HouseholdProfile")
                        .WithMany("HouseholdMembers")
                        .HasForeignKey("HouseholdProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp.Data.EntityModel.Person", "Person")
                        .WithOne("HouseholdMember")
                        .HasForeignKey("HealthWebApp.Data.EntityModel.Household.HouseholdMember", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Household.HouseholdProfile", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Barangays.Barangay", "Barangay")
                        .WithMany()
                        .HasForeignKey("BarangayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Person", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Household.Family", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId");

                    b.HasOne("HealthWebApp.Data.EntityModel.NameTitle", "NameTitle")
                        .WithMany()
                        .HasForeignKey("NameTitleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp.Data.EntityModel.Religion", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp.Data.EntityModel.Work", "Work")
                        .WithMany()
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.PhilHealthFolder.PhilHealth", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Person")
                        .WithOne("PhilHealth")
                        .HasForeignKey("HealthWebApp.Data.EntityModel.PhilHealthFolder.PhilHealth", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HealthWebApp.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HealthWebApp.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthWebApp.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
