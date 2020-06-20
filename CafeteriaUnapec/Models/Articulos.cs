using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class Articulos
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Nombre_Marca { get; set; }
        public float Precio { get; set; }
        public string Proveedor { get; set; }
        public int Unidades_existentes { get; set; }
        public bool Estado { get; set; }
    }
    public class ArticuloDbContext : DbContext
    {
        public DbSet <Articulos> Articulos { get; set; }
    }
}