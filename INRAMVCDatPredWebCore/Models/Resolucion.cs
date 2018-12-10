using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace INRAMVCDatPredWebCore.Models
{
    public class Resolucion
    {
        [Key]
        public int ResolcuionId { get; set; }
        [Required(ErrorMessage = "El campo IDCarpeta es obligatorio.")]
        [MaxLength(6)]
        [MinLength(6)]
        [RegularExpression("[TJCBCH]{1,2}[0-9]{1,4}", ErrorMessage = "El formato es incorrecto Ejm. TJ0125.")]
        public string IDCarpeta { get; set; }        
        [Required(ErrorMessage = "El campo Predio es obligatorio.")]
        public string AgrupacionSocial { get; set; }        
        [Required(ErrorMessage = "El campo Poligono es obligatorio.")]
        //[RegularExpression("^[0-9]$", ErrorMessage = "...")]
        [Range(0, 9, ErrorMessage = "...")]        
        public int Poligono { get; set; }
        [Required(ErrorMessage = "El campo Expediente es obligatorio.")]
        public string Expediente { get; set; }
        [Required]
        public string ClaseResolucion { get; set; }
        [Required]
        public string TipoResolucion { get; set; }
        public DateTime FechaRegistro { get; set; }
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }        
    }
}
