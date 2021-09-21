using Microsoft.EntityFrameworkCore;
using proEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proEventos.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configuração: map entidade das tabelas:
            modelBuilder.Entity<Evento>().ToTable("Evento");

            //Configuração da Primary Keys:
            modelBuilder.Entity<Evento>().HasKey(e => e.Id).HasName("Id");

            //Configuração dos index:
            modelBuilder.Entity<Evento>().HasIndex(e => e.Tema).IsUnique().HasDatabaseName("Idx_Tema");

            //Configuração columns:
            //modelBuilder.Entity<Evento>().Property(e => e.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            //modelBuilder.Entity<Evento>().Property(e => e.Local).HasColumnType("varchar(100)").UseMySqlIdentityColumn().IsRequired(false);
            //modelBuilder.Entity<Evento>().Property(e => e.DataEvento).HasColumnType("varchar(100)").UseMySqlIdentityColumn().IsRequired(false);
            //modelBuilder.Entity<Evento>().Property(e => e.Tema).HasColumnType("varchar(100)").UseMySqlIdentityColumn().IsRequired(false);
            //modelBuilder.Entity<Evento>().Property(e => e.QtdPessoas).HasColumnType("int").UseMySqlIdentityColumn().IsRequired(false);
            //modelBuilder.Entity<Evento>().Property(e => e.Lote).HasColumnType("int").UseMySqlIdentityColumn().IsRequired(false);
            //modelBuilder.Entity<Evento>().Property(e => e.ImageURL).HasColumnType("varchar(100)").UseMySqlIdentityColumn().IsRequired(false);

            //Configuração de relacionamento
            //modelBuilder.Entity< "Aqui vai ficar a tabela do ounte estra a pk" > ().HasOne<"Aqui vai ficar a tabela do ounte estra a fk">().WithMany().HasPrincipalKey(ug => ug.Id).HasForeignKey(u => u.UserGroupId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Users_UserGroups");
        }
    }
}
