using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBiblioteca.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código")]
        public int UsuarioId { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome Completo")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("RmUsuario")]
        [Display(Name = "RM")]
        public string RmUsuario { get; set; } = string.Empty;
    }
}
