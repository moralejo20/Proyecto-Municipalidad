using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Municipalidad.Models
{
    public class Noticia

    {
        [Key]
        public int id { set; get; }
        [Required]
        [StringLength(50)]
        public string noticaTitulo { set; get; }
        [Required]
        [StringLength(500)]
        public string cuerpoNoticia { set; get; }
        [Required]
        [StringLength(50)]
        public string autorNoticia { set; get; }



    }
}
