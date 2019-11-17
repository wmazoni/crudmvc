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
        public string nome { get; set; }
        public string descricao { get; set; }
        public string data { get; set; }
    }
}