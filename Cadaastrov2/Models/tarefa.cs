using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cadaastrov2.Models
{
    public class tarefa
    {
        [Key]
        public int codio { get; set; }

        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "O nome da tarefa pode ter no máximo 50 caracteres")]
        [Required]
        public string nome { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Display(Name = "Data Entrega")]
        [DataType(DataType.Date)]
        public string data { get; set; }
    }
}