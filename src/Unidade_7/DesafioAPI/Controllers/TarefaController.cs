using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using AspNetCoreGeneratedDocument;
using Desafio_API.Context;
using Desafio_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_API.Controllers
{
    public class TarefaController : Controller
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (ModelState.IsValid)
                _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Deletar(Tarefa tarefa)
        {
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult FiltrarTarefaStatus(string status)
        {
            var tarefa =
                        string.IsNullOrEmpty(status)    ? 
                        _context.Tarefas.ToList()       :
                        _context.Tarefas.Where(x => x.StatusTarefa == status).ToList();

            return View("Index", tarefa);
        }
        [HttpGet]
        public IActionResult FiltrarTarefaTitulo(string titulo)
        {
            var tarefa =
                        string.IsNullOrEmpty(titulo)    ? 
                        _context.Tarefas.ToList()       :
                        _context.Tarefas.Where(x => x.Titulo == titulo).ToList();

            return View("Index", tarefa);
        }
    }
}