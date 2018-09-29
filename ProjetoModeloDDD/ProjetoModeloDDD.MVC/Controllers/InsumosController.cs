using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class InsumosController : Controller
    {
        private readonly IInsumoAppService _insumoApp;
        private readonly IFornecedorAppService _fornecedorApp;

        public InsumosController(IInsumoAppService insumoApp, IFornecedorAppService fornecedorApp)
        {
            _insumoApp = insumoApp;
            _fornecedorApp = fornecedorApp;
        }

        public ActionResult Index()
        {
            var insumoViewModel = Mapper.Map<IEnumerable<Insumos>, IEnumerable<InsumoViewModel>>(_insumoApp.GetAll());
            return View(insumoViewModel);
        }

        public ActionResult Detalhes(int id)
        {
            var insumo = _insumoApp.GetById(id);
            var insumoViewModel = Mapper.Map<Insumos, InsumoViewModel>(insumo);
            return View(insumoViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Criar()
        {
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(InsumoViewModel insumo)
        {
            if (ModelState.IsValid)
            {
                var insumoDomain = Mapper.Map<InsumoViewModel, Insumos>(insumo);
                _insumoApp.Add(insumoDomain);
                return RedirectToAction("Index");
            }
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", insumo.FornecedorId);
            return View(insumo);
        }

        // GET: Clientes/Edit/5
        public ActionResult Editar(int id)
        {
            var insumo = _insumoApp.GetById(id);
            var insumoViewModel = Mapper.Map<Insumos, InsumoViewModel>(insumo);

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", insumoViewModel.FornecedorId);

            return View(insumoViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(InsumoViewModel insumo)
        {
            if (ModelState.IsValid)
            {
                var insumoDomain = Mapper.Map<InsumoViewModel, Insumos>(insumo);
                _insumoApp.Update(insumoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", insumo.FornecedorId);

            return View(insumo);
        }


        public ActionResult Deletar(int id)
        {
            var insumo = _insumoApp.GetById(id);
            var insumoViewModel = Mapper.Map<Insumos, InsumoViewModel>(insumo);

            return View(insumoViewModel);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            var insumo = _insumoApp.GetById(id);
            _insumoApp.remove(insumo);

            return RedirectToAction("Index");
        }
    }
}