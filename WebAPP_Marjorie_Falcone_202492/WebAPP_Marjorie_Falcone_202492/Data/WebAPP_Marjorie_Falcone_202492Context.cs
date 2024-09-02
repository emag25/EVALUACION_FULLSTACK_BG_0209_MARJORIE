using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPP_Marjorie_Falcone_202492.Models;

namespace WebAPP_Marjorie_Falcone_202492.Data
{
    public class WebAPP_Marjorie_Falcone_202492Context : DbContext
    {
        public WebAPP_Marjorie_Falcone_202492Context (DbContextOptions<WebAPP_Marjorie_Falcone_202492Context> options)
            : base(options)
        {
        }

        public DbSet<WebAPP_Marjorie_Falcone_202492.Models.Reserva> Reserva { get; set; } = default!;
    }
}
