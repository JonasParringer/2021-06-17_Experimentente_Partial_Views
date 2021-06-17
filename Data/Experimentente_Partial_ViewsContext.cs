using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_17_Experimentente_Partial_Views.Models;

    public class Experimentente_Partial_ViewsContext : DbContext
    {
        public Experimentente_Partial_ViewsContext (DbContextOptions<Experimentente_Partial_ViewsContext> options)
            : base(options)
        {
        }

        public DbSet<_2021_06_17_Experimentente_Partial_Views.Models.Document> Document { get; set; }
    }
