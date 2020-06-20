using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CafeteriaUnapec.Models
{
    public class UserTypes
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
    public class UsserTypesCafeteriaUnapecContext: DbContext
    {
        public DbSet<UserTypes> UserTypes { get; set; }
    }
}