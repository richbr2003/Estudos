using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Estudos.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Estudo")
        {

        }
        //public DbSet<Administradores> administradores { get; set; }
        //public DbSet<Lanches> lanches { get; set; }
        //public DbSet<BebidasTipo> bebidastipo { get; set; }
        public DbSet<Pessoa> pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Administradores>().Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(75);
            //modelBuilder.Entity<Administradores>().Property(x => x.Senha).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            //modelBuilder.Entity<Administradores>().Property(x => x.Role).IsRequired().HasColumnType("varchar").HasMaxLength(15);

            //modelBuilder.Entity<ClienteCarrinho>()
            //.HasMany(o => o.Carrinhos)
            //.WithOptional()
            //.HasForeignKey(c => c.CodCli);

        }

    }
}