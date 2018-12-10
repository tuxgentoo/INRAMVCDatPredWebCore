using System;
using System.Collections.Generic;
using System.Text;
using INRAMVCDatPredWebCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace INRAMVCDatPredWebCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Cambiaremos el nombre de la table AspNetUsers a User
            builder.Entity<ApplicationUser>().ToTable("Users");
            //Cambiaremos los nombres de todas las tablas 
            builder.Entity<ApplicationRole>().ToTable("Roles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");

            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        }

        public DbSet<INRAMVCDatPredWebCore.Models.Resolucion> Resoluciones { get; set; }
        public DbSet<INRAMVCDatPredWebCore.Models.Carpeta> Carpetas { get; set; }
        public DbSet<INRAMVCDatPredWebCore.Models.Departamento> Departamentos { get; set; }
        public DbSet<INRAMVCDatPredWebCore.Models.Provincia> Provincias { get; set; }
        public DbSet<INRAMVCDatPredWebCore.Models.Municipio> Municipios { get; set; }
        public DbSet<INRAMVCDatPredWebCore.Models.Ubicacion> Ubicaciones { get; set; }
    }
}
