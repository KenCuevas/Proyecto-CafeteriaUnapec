using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class Proveedores
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int RNC { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =
        "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime? Fecha { get; set; }
        public  bool Estado { get; set; }
    }

    public class ProveedorDbContext : DbContext
    {
        public DbSet<Proveedores> Proveedores { get; set; }
    }
}