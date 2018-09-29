using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorAppService _colaboradorApp;

        public ColaboradorController(IColaboradorAppService colaboradorApp)
        {
            _colaboradorApp = colaboradorApp;
        }

        public ActionResult Index()
        {
            var colaboradorViewModel = Mapper.Map<IEnumerable<Colaboradores>, IEnumerable<ColaboradorViewModel>>(_colaboradorApp.GetAll());
            return View(colaboradorViewModel);
        }

        public ActionResult Detalhes(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            var colaboradorViewModel = Mapper.Map<Colaboradores, ColaboradorViewModel>(colaborador);
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(ColaboradorViewModel colaborador)
        {
            if (ModelState.IsValid)
            {
                var colaboradorDomain = Mapper.Map<ColaboradorViewModel, Colaboradores>(colaborador);
                _colaboradorApp.Add(colaboradorDomain);
                return RedirectToAction("Index");
            }
            return View(colaborador);
        }

        // GET: Clientes/Edit/5
        public ActionResult Editar(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            var colaboradorViewModel = Mapper.Map<Colaboradores, ColaboradorViewModel>(colaborador);
            return View(colaboradorViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ColaboradorViewModel colaborador)
        {
            if (ModelState.IsValid)
            {
                var colaboradorDomain = Mapper.Map<ColaboradorViewModel, Colaboradores>(colaborador);
                _colaboradorApp.Update(colaboradorDomain);
                return RedirectToAction("Index");
            }
            return View(colaborador);
        }


        public ActionResult Delete(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            var colaboradorViewModel = Mapper.Map<Colaboradores, Colaboradores>(colaborador);
            return View(colaboradorViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var colaborador = _colaboradorApp.GetById(id);
            _colaboradorApp.remove(colaborador);
            return RedirectToAction("Index");
        }
    }
}