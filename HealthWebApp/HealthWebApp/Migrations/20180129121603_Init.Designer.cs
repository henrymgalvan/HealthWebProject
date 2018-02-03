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
    [Migration("20180129121603_Init")]
    partial class Init
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

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.Household.HouseholdMember", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("HouseholdProfileId");

                    b.Property<long>("PersonId");

                    b.Property<int>("RelationToHead");

                    b.HasKey("Id");

                    b.HasIndex("HouseholdProfileId");

                    b.HasIndex("PersonId")
                        .IsUnique();

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

                    b.Property<string>("Note");

                    b.Property<string>("ProfileId");

                    b.HasKey("Id");

                    b.HasIndex("BarangayId");

                    b.ToTable("HouseholdProfile");
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

                    b.Property<string>("ExtensionName")
                        .HasMaxLength(3);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("NameTitle")
                        .HasMaxLength(30);

                    b.Property<bool>("PersonConsent");

                    b.Property<int>("Sex");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.PhilHealthFolder.PhilHealth", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<DateTime>("DateAssigned");

                    b.Property<int>("EmployerType");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("Identification");

                    b.Property<int>("Individual");

                    b.Property<bool>("Lifetime");

                    b.Property<long>("PersonId");

                    b.Property<int>("Sponsored");

                    b.Property<int>("StatusType");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PhilHealth");
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

            modelBuilder.Entity("HealthWebApp.Data.EntityModel.PhilHealthFolder.PhilHealth", b =>
                {
                    b.HasOne("HealthWebApp.Data.EntityModel.Person", "Person")
                        .WithMany("PhilHealth")
                        .HasForeignKey("PersonId")
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
