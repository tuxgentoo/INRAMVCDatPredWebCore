using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace INRAMVCDatPredWebCore.Models
{
    public class Carpeta
    {
        [Key]
        public int CarpetaId { get; set; }
        [Required(ErrorMessage = "El campo IDCarpeta es obligatorio.")]
        [MaxLength(6)]
        [MinLength(6)]
        [RegularExpression("[TJCBCH]{1,2}[0-9]{1,4}", ErrorMessage = "El formato es incorrecto Ejm. TJ0125.")]
        public string IDCarpeta { get; set; }
        [Required(ErrorMessage = "El campo AgrupacionSocial es obligatorio.")]
        public string AgrupacionSocial { get; set; }
        [Required]
        [Range(1, short.MaxValue, ErrorMessage = "El valor {0} debe ser numérico.")]
        public int Cuerpos { get; set; }
        [Required]
        [Range(1, short.MaxValue, ErrorMessage = "El valor {0} debe ser numérico.")]
        public int Fojas { get; set; }
        [Required(ErrorMessage = "El campo Poligono es obligatorio.")]
        public int Poligono { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        //public List<Predio> Predios { get; set; }
        [Required]
        [ForeignKey("Departamento")]        
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        [ForeignKey("Provincia")]        
        public int? ProvinciaId { get; set; }
        //[Required]
        public Provincia Provincia { get; set; }
        [ForeignKey("Municipio")]        
        public int? MunicipioId { get; set; }        
        public Municipio Municipio { get; set; }
        [ForeignKey("ApplicationUser")]
        public String Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("Ubicacion")]        
        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
