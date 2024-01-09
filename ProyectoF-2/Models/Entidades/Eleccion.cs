using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoF_2.Models.Entidades
{
    public class Eleccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_eleccion { get; set; }
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public string descripcion { get; set; }
        public string cargo { get; set; }
        public string fecha_registro { get; set; }
        // claves foraneas
        public int id_usuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
