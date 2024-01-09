using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoF_2.Models.Entidades
{
    public class Votacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_votacion { get; set; }
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public string fecha_votacion { get; set; }
        // fecha registro
        public string id_candidato { get; set; }
        public Candidato Candidato { get; set; }
    }
}
