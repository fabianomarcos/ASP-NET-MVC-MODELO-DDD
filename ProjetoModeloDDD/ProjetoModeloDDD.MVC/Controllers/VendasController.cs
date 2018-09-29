using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class VendasController : Controller
    {
        private readonly IVendasAppService _vendaApp;
        private readonly IClienteAppService _clienteApp;
        private readonly IColaboradorAppService _colaboradorApp;
        private readonly IProdutoAppService _produtoApp;

        public VendasController(IVendasAppService vendaApp, IClienteAppService clienteApp, IColaboradorAppService colaboradorApp,IProdutoAppService produtoApp)
        {
            _vendaApp = vendaApp;
            _clienteApp = clienteApp;
            _colaboradorApp = colaboradorApp;
            _produtoApp = produtoApp;
        }
       // public ActionResult Itens()
        //{
         //   var itensViewModel = Mapper.Map<
        //}
        public ActionResult Index()
        {
            var vendaViewModel = Mapper.Map<IEnumerable<Vendas>, IEnumerable<VendaViewModel>>(_vendaApp.GetAll());
            return View(vendaViewModel);
        }

        // GET: Vendas/Details/5
        public ActionResult Detalhes(int id)
        {
            var venda = _vendaApp.GetById(id);
            var vendaViewModel = Mapper.Map<Vendas, VendaViewModel>(venda);
            return View(vendaViewModel);
        }

        public ActionResult Criar()
        {
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome");
            ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(),"ProdutoId","Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(VendaViewModel vendas)
        {
            if (ModelState.IsValid)
            {
                var VendasDomain = Mapper.Map<VendaViewModel, Vendas>(vendas);
                _vendaApp.Add(VendasDomain);
                return RedirectToAction("Index");
                
            }
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", vendas.ClienteId);
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", vendas.ColaboradorId);
            ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "ProdutoId", "Nome", vendas.ProdutoId);
            return View(vendas);
        }



        // GET: Vendas/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Vendas/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vendas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
