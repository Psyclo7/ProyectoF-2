using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoF_2.Models.Entidades
{
    public class Candidato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_candidato { get; set; }
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public string nombre_candidato { get; set; }
        public string mensaje { get; set; }
        // estas son las claves foraneas
        public string id_eleccion { get; set; }
        public Eleccion Eleccion { get; set; }
    }
}
