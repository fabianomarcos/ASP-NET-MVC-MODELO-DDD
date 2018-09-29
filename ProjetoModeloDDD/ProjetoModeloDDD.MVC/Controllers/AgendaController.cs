using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class AgendaController : Controller
    {
        private readonly IAgendaAppService _agendaApp;
        private readonly IClienteAppService _clienteApp;
        private readonly IColaboradorAppService _colaboradorApp;
        private readonly IServicoAppService _servicoApp;
        private readonly IHorarioAppService _horarioApp;

        public AgendaController(IAgendaAppService agendaApp, IClienteAppService clienteApp,IServicoAppService servicoApp,IColaboradorAppService colaboradorApp,IHorarioAppService horarioApp)
        {
            _agendaApp = agendaApp;
            _clienteApp = clienteApp;
            _servicoApp = servicoApp;
            _colaboradorApp = colaboradorApp;
            _horarioApp = horarioApp;
        }
        public ActionResult CadastrarHorarios()
        {
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarHorarios(AgendaViewModel agenda)
        {
            if ((DateTime.Now > agenda.Data))
            {
                ModelState.AddModelError("Data", "Campo Data: Data inválida!");
            }
            if (ModelState.IsValid)
            {
                var agendaDomain = Mapper.Map<AgendaViewModel, Agenda>(agenda);
                _agendaApp.Add(agendaDomain);
                return RedirectToAction("Index");
            }
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agenda.ColaboradorId);
            return View(agenda);
        }
        public ActionResult Cadastrar(string profissional)
        {
            var horarioViewModel = Mapper.Map<IEnumerable<Horarios>, IEnumerable<HorariosViewModel>>(_horarioApp.BuscarPorNome(profissional));
            return View(horarioViewModel);
        }
        public ActionResult Index(string profissional)
        {
            var agendaViewModel = Mapper.Map<IEnumerable<Agenda>, IEnumerable<AgendaViewModel>>(_agendaApp.BuscarPorNome(profissional));
            return View(agendaViewModel);
        }

        public ActionResult Detalhes(int id)
        {
            var agenda = _agendaApp.GetById(id);
            var agendaViewModel = Mapper.Map<Agenda, AgendaViewModel>(agenda);
            return View(agendaViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Criar()
        {
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome");
            ViewBag.ServicosId = new SelectList(_servicoApp.GetAll(), "ServicosId", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(AgendaViewModel agenda)
        {
            if((DateTime.Now < agenda.Data))
            {
                ModelState.AddModelError("Data", "Campo Data: Data inválida!");               
            }
            if (ModelState.IsValid)
            {
                var agendaDomain = Mapper.Map<AgendaViewModel, Agenda>(agenda);
                _agendaApp.Add(agendaDomain);
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", agenda.ClienteId);
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome",agenda.ColaboradorId);
            ViewBag.ServicosId = new SelectList(_servicoApp.GetAll(), "ServicosId", "Nome",agenda.ServicosId);
            return View(agenda);
        }

        // GET: Clientes/Edit/5
        public ActionResult EditarHorariosColaborador(int id)
        {
            var agenda = _agendaApp.GetById(id);
            var agendaViewModel = Mapper.Map<Agenda, AgendaViewModel>(agenda);

            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome",agendaViewModel.ColaboradorId);

            return View(agendaViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarHorariosColaborador(AgendaViewModel agenda)
        {
            if (ModelState.IsValid)
            {
                var agendaDomain = Mapper.Map<AgendaViewModel, Agenda>(agenda);
                _agendaApp.Update(agendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agenda.ColaboradorId);

            return View(agenda);
        }

        public ActionResult EditarAgendamento(int id)
        {
            var agenda = _agendaApp.GetById(id);
            var agendaViewModel = Mapper.Map<Agenda, AgendaViewModel>(agenda);

            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agendaViewModel.ColaboradorId);
            ViewBag.ClienteId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agendaViewModel.ClienteId);
            ViewBag.ServicoId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agendaViewModel.ServicosId);

            return View(agendaViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAgendamento(AgendaViewModel agenda)
        {
            if (ModelState.IsValid)
            {
                var agendaDomain = Mapper.Map<AgendaViewModel, Agenda>(agenda);
                _agendaApp.Update(agendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.ColaboradorId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agenda.ColaboradorId);
            ViewBag.ClienteId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agenda.ClienteId);
            ViewBag.ServicoId = new SelectList(_colaboradorApp.GetAll(), "ColaboradorId", "Nome", agenda.ServicosId);

            return View(agenda);
        }

        public ActionResult Deletar(int id)
        {
            var agenda = _agendaApp.GetById(id);
            var agendaViewModel = Mapper.Map<Agenda, AgendaViewModel>(agenda);

            return View(agendaViewModel);
        }

        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            var agenda = _agendaApp.GetById(id);
            _agendaApp.remove(agenda);

            return RedirectToAction("Index");
        }
    }
}