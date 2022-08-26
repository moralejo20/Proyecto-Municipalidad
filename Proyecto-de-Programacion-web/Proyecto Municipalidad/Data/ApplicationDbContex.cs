using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Municipalidad.Models;
using Proyecto_Municipalidad.Data.Migrations;

namespace Proyecto_Municipalidad.Data
{
    public class ApplicationDbContex : IdentityDbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options)
            : base(options)
        {
        }
        public DbSet<Proyecto_Municipalidad.Models.Noticia> Noticia { get; set; }
        public DbSet<Proyecto_Municipalidad.Models.Evento> Evento { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Noticia>().ToTable("Equipo");
            modelBuilder.Entity<Evento>().ToTable("Equipo2");
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<//>().ToTable("//");
        }
    }
}
