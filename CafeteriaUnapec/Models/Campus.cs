using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class Campus
    {
        public Campus() {
            this.Cafeteria = new HashSet<Cafeteria>();
        }

        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public virtual ICollection<Cafeteria> Cafeteria { get; set; }
    }
    public class CampusCafeteriaUnapec : DbContext
    {
        public DbSet<Campus> Campus { get; set; }
    }
}