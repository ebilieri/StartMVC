using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Start.UI.Site.Data;
using Start.UI.Site.Models;

namespace Start.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly StartMVCDbContext _contexto;

        public TesteCrudController(StartMVCDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno { 
                Nome = "Emerson",
                DataNascimento = DateTime.Now,
                Email = "ebilieri@hotmail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var getAluno = _contexto.Alunos.Find(aluno.Id);
            var getAluno2 = _contexto.Alunos.FirstOrDefault(a => a.Email == "ebilieri@hotmail.com");
            var getAluno3 = _contexto.Alunos.Where(a => a.Nome == "Jose");

            aluno.Nome = "Jose";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();


            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();


            return View("_Layout");
        }
    }
}