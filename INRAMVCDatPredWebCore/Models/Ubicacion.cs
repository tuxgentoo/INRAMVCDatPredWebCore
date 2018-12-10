using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace INRAMVCDatPredWebCore.Models
{
    public class Ubicacion
    {
        [Key]
        public int UbicacionId { get; set; }
        [Required(ErrorMessage = "El campo Ubicacion es obligatorio.")]
        public string Nombre { get; set; }        
        public ICollection<Carpeta> Carpetas { get; set; }
    }
}
