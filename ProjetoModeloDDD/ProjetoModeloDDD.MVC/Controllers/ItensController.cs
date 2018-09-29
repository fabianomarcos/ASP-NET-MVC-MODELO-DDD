using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ItensController : Controller
    {
        public ActionResult ListarItens(int Id)
        {
            var itemViewModel = Mapper.Map<IEnumerable<Itens>, IEnumerable<ItensViewModel>>(_itemApp.BuscarPorId(Id));
            ViewBag.Venda = Id;
            return PartialView(itemViewModel);
        }

        private readonly IItemAppService _itemApp;

        public ItensController(IItemAppService itemApp)
        {
            _itemApp = itemApp;
        }

        //alterei produto
        public ActionResult SalvarItens(int quantidade, Produtos produto, int valorunitario, int idVenda)
        {
            var itens = _itemApp.GetById(idVenda);
            var itensViewModel = Mapper.Map<Itens, ItensViewModel>(itens);
            var item = new Itens()
            {

                Quantidade = quantidade
                ,
                Produto = produto
                ,
                ValorUnitario = valorunitario
                ,
    //            Venda = itens.ItensId
        };
      //      _itemApp.Add.(item);
            
            

            return Json(new { Resultado = item.Venda.VendasId}, JsonRequestBehavior.AllowGet);
        }
    }

}