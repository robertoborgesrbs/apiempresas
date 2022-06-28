using ApiEmpresas.Domain.Entities;
using ApiEmpresas.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contexto do EntityFramework
    /// </summary>
    public class SqlServerContext : DbContext
    {
        //Método para fazer a conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDApiEmpresas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            optionsBuilder.UseSqlServer(@"Data Source=SQL5105.site4now.net;Initial Catalog=db_a8831e_apiempresas;User ID=db_a8831e_apiempresas_admin;Password=root123456");
        }

        //método para adicionar as classes de mapeamento
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
        }

        //propriedades DbSet para cada classe de entidade
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}




