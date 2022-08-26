using System.ComponentModel.DataAnnotations;

namespace Proyecto_Municipalidad.Models
{
    public class Evento
    {
        [Key]
        public int idEvento { set; get; }
        [Required]
        [StringLength(50)]
        public string eventoTitulo { set; get; }
        [Required]
        [StringLength(500)]
        public string cuerpoevento { set; get; }
        [Required]
        [StringLength(50)]
        public string autorEvento { set; get; }



    }
}
