using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CORE.Model
{
    public class PoliticaModel
    {
        [Key]
        public int PoliticaId { get; set; }
        [Required]
        [Display(Name ="Descripcion")]
        public String Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
