using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class Marcas
    {
        public int ID { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
    public class MarcaDbContext : DbContext
    {
        public DbSet<Marcas> Marcas { get; set; }
    }
}