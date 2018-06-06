using Rejestracja_na_praktyki_w_Billennium.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rejestracja_na_praktyki_w_Billennium.DAL
{
    public class PraktykiContext : DbContext
    {
        public PraktykiContext() : base("PraktykiContext")
        {

        }

        public DbSet<Praktykant> Praktykant { get; set; }
    }
}