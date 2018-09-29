using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IFornecedorAppService _fornecedorApp;

        public ProdutosController(IProdutoAppService produtoApp, IFornecedorAppService fornecedorApp)
        {
            _produtoApp = produtoApp;
            _fornecedorApp = fornecedorApp;
        }

        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produtos>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        }

        public ActionResult Detalhes(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produtos, ProdutoViewModel>(produto);
            return View(produtoViewModel);
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
        public ActionResult Criar(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produtos>(produto);
                _produtoApp.Add(produtoDomain);
                return RedirectToAction("Index");
            }
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", produto.FornecedorId);
            return View(produto);
        }

        // GET: Clientes/Edit/5
        public ActionResult Editar(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produtos, ProdutoViewModel>(produto);

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", produtoViewModel.FornecedorId);

            return View(produtoViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produtos>(produto);
                _produtoApp.Update(produtoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", produto.FornecedorId);

            return View(produto);
        }


        public ActionResult Deletar(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produtos, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoApp.GetById(id);
            _produtoApp.remove(produto);

            return RedirectToAction("Index");
        }
    }
}