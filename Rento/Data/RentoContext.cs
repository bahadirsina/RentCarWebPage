using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rento.Data
{
    public class RentoContext : DbContext
    {

        public RentoContext() : base("name=RentoContext")
        {
        }

        public System.Data.Entity.DbSet<Rento.Models.Car> Cars { get; set; }
    }
}
