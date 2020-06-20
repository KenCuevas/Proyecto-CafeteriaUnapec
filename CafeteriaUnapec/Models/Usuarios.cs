using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeteriaUnapec.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Tipo_usuarios { get; set; }
        public int limite_credito { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =
        "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }
    }
    public class UsuarioDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
    }

}