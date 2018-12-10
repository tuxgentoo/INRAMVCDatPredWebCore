﻿// <auto-generated />
using System;
using INRAMVCDatPredWebCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace INRAMVCDatPredWebCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181209005651_Ocho")]
    partial class Ocho
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("Activo");

                    b.Property<string>("Apellidos");

                    b.Property<string>("Cargo");

                    b.Property<int>("Ci");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nombres");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Profesion");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Carpeta", b =>
                {
                    b.Property<int>("CarpetaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgrupacionSocial")
                        .IsRequired();

                    b.Property<int>("Cuerpos");

                    b.Property<int>("DepartamentoId");

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<int>("Fojas");

                    b.Property<string>("IDCarpeta")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Id");

                    b.Property<int?>("MunicipioId");

                    b.Property<int>("Poligono");

                    b.Property<int?>("ProvinciaId");

                    b.Property<int>("UbicacionId");

                    b.HasKey("CarpetaId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("ProvinciaId");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Carpeta");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Municipio", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("ProvinciaId");

                    b.HasKey("MunicipioId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Provincia", b =>
                {
                    b.Property<int>("ProvinciaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ProvinciaId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Resolucion", b =>
                {
                    b.Property<int>("ResolcuionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgrupacionSocial")
                        .IsRequired();

                    b.Property<string>("ClaseResolucion")
                        .IsRequired();

                    b.Property<string>("Expediente")
                        .IsRequired();

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<string>("IDCarpeta")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Id");

                    b.Property<int>("Poligono");

                    b.Property<string>("TipoResolucion")
                        .IsRequired();

                    b.HasKey("ResolcuionId");

                    b.HasIndex("Id");

                    b.ToTable("Resolucion");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Ubicacion", b =>
                {
                    b.Property<int>("UbicacionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("UbicacionId");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Carpeta", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.Departamento", "Departamento")
                        .WithMany("Carpetas")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Carpetas")
                        .HasForeignKey("Id");

                    b.HasOne("INRAMVCDatPredWebCore.Models.Municipio", "Municipio")
                        .WithMany("Carpetas")
                        .HasForeignKey("MunicipioId");

                    b.HasOne("INRAMVCDatPredWebCore.Models.Provincia", "Provincia")
                        .WithMany("Carpetas")
                        .HasForeignKey("ProvinciaId");

                    b.HasOne("INRAMVCDatPredWebCore.Models.Ubicacion", "Ubicacion")
                        .WithMany("Carpetas")
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Municipio", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.Provincia", "Provincia")
                        .WithMany("Municipios")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Provincia", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.Departamento", "Departamento")
                        .WithMany("Provincias")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("INRAMVCDatPredWebCore.Models.Resolucion", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Resoluciones")
                        .HasForeignKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("INRAMVCDatPredWebCore.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
