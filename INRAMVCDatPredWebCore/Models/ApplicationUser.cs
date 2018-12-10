using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace INRAMVCDatPredWebCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }
        public int Ci { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        //public string Celular { get; set; }
        public string Cargo { get; set; }
        public string Profesion { get; set; }
        public Boolean Activo { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", Nombres, Apellidos);
            }
        }
        public ICollection<Resolucion> Resoluciones { get; set; }
        public ICollection<Carpeta> Carpetas { get; set; }
    }
}
