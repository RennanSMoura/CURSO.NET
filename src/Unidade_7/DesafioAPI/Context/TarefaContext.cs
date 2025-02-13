using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio_API.Models;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Desafio_API.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base (options){}

        public DbSet<Tarefa> Tarefas {get; set;}
    }
}