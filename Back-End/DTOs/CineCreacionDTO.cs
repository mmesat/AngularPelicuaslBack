using System.ComponentModel.DataAnnotations;

namespace Back_End.DTOs
{
    public class CineCreacionDTO
    {
        [Required]
        [StringLength(maximumLength:75)]
        public string Nombre { get; set; }
        [Range(-90,90)]
        public double Latitud { get; set; }
        [Range(-180,180)]
        public double Longitud { get; set; }

    }
}
