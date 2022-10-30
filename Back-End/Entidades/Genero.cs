using Back_End.Validaciones;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Back_End.Entidades
{
    public class Genero 
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength:50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public List<PeliculasGeneros> PeliculasGeneros { get; set; }

    }
}
