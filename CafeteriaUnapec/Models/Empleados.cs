using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class Empleados
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =
       "{0:yyyy-MM-dd}",
         ApplyFormatInEditMode = true)]
        public DateTime? Nacimiento { get; set; }
        public string Tanda_labor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =
     "{0:yyyy-MM-dd}",
       ApplyFormatInEditMode = true)]
        public DateTime? Fecha_Entrada { get; set; }
        public  bool Estado { get; set; }

    }
    public class EmpleadoDbContext : DbContext
    {
        public DbSet<Empleados> Empleado { get; set; }
    }
}