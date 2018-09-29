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
    public class HorarioController : Controller
    {
        private readonly IHorarioAppService _horarioApp;
        private readonly IColaboradorAppService _colaboradorApp;

        public HorarioController(IHorarioAppService horarioApp, IColaboradorAppService colaboradorApp)
        {
            _horarioApp = horarioApp;
            _colaboradorApp = colaboradorApp;
        }

        public ActionResult Index(string profissional)
        {
            var horarioViewModel = Mapper.Map<IEnumerable<Horarios>, IEnumerable<HorariosViewModel>>(_horarioApp.BuscarPorNome(profissional));
            return View(horarioViewModel);
        }
        public ActionResult Detalhes(int id)
        {
            var horario = _horarioApp.GetById(id);
            var horarioViewModel = Mapper.Map<Horarios, HorariosViewModel>(horario);
            return View(horarioViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Criar()
        {
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(HorariosViewModel horario)
        {
            if (ModelState.IsValid)
            {
                var horarioDomain = Mapper.Map<HorariosViewModel, Horarios>(horario);
                _horarioApp.Add(horarioDomain);
                return RedirectToAction("Index");
            }
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboraforId", "Nome", horario.ColaboradorId);
            return View(horario);
        }

        /*GET: Clientes/Edit/5
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
        }*/
    }
}