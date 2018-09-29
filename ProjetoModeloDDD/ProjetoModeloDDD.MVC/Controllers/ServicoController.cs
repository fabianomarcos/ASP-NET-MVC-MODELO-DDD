using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ServicoController : Controller
    {
        private readonly IInsumoAppService _insumoApp;
        private readonly IServicoAppService _servicoApp;

        public ServicoController(IServicoAppService servicoApp, IInsumoAppService insumoApp)
        {
            _servicoApp = servicoApp;
            _insumoApp = insumoApp;
        }

        public ActionResult Index()
        {
            var servicoViewModel = Mapper.Map<IEnumerable<Services>, IEnumerable<ServiceViewModel>>(_servicoApp.GetAll());
            return View(servicoViewModel);
        }

        public ActionResult Detalhes(int id)
        {
            var servico = _servicoApp.GetById(id);
            var servicoViewModel = Mapper.Map<Services, ServiceViewModel>(servico);
            return View(servicoViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Criar()
        {
            ViewBag.InsumoId = new SelectList(_insumoApp.GetAll(), "InsumoId", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(ServiceViewModel servico)
        {
            if (ModelState.IsValid)
            {
                var servicoDomain = Mapper.Map<ServiceViewModel, Services>(servico);
                _servicoApp.Add(servicoDomain);
                return RedirectToAction("Index");
            }
            ViewBag.InsumoId = new SelectList(_insumoApp.GetAll(), "InsumoId", "Nome", servico.InsumoId);
            return View(servico);
        }

        // GET: Clientes/Edit/5
        public ActionResult Editar(int id)
        {
            var servico = _servicoApp.GetById(id);
            var servicoViewModel = Mapper.Map<Services, ServiceViewModel>(servico);

            ViewBag.InsumoId = new SelectList(_insumoApp.GetAll(), "InsumoId", "Nome", servicoViewModel.InsumoId);

            return View(servicoViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ServiceViewModel servico)
        {
            if (ModelState.IsValid)
            {
                var servicoDomain = Mapper.Map<ServiceViewModel, Services>(servico);
                _servicoApp.Update(servicoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.InsumoId = new SelectList(_insumoApp.GetAll(), "InsumoId", "Nome", servico.InsumoId);

            return View(servico);
        }


        public ActionResult Deletar(int id)
        {
            var servico = _servicoApp.GetById(id);
            var servicoViewModel = Mapper.Map<Services, ServiceViewModel>(servico);

            return View(servicoViewModel);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            var servico = _servicoApp.GetById(id);
            _servicoApp.remove(servico);

            return RedirectToAction("Index");
        }
    }
}