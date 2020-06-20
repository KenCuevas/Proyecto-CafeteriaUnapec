using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class Cafeteria
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public  virtual Campus Campus { get; set; }
        public virtual Empleados Encargado { get; set; }
        public bool Estado { get; set; }
    }
    public class CafeteriaCafeteriaUnapec : DbContext
    {
        public DbSet<Cafeteria> Cafeteria { get; set; }
    }
}