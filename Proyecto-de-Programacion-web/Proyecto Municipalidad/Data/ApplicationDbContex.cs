using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Municipalidad.Models;

namespace Proyecto_Municipalidad.Data
{
    public class ApplicationDbContex : IdentityDbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options)
            : base(options)
        {
        }
        public DbSet<Proyecto_Municipalidad.Models.Noticia> Noticia { get; set; }
    }
}
