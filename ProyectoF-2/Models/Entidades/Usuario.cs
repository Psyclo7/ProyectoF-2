using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoF_2.Models.Entidades
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_usuario { get; set; }
        [Required(ErrorMessage = "Este campo {0} es obligatorio")]
        public string documento_identidad { get; set; }
        public string nombre_usuario { get; set; }
        public string apellido_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string clave_usuario { get; set; }
    }
}
