using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cadaastrov2.Models
{
    public class contexto : DbContext
    {
        public DbSet<tarefa> Tarefas { get; set; }

    }
}