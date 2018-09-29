using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class ItemAppService : AppServiceBase<Itens>, IItemAppService
    {
        private readonly IItemService _itemService;

        public ItemAppService(IItemService itemService) : 
            base(itemService)
        {
            _itemService = itemService;
        }
        public IEnumerable<Itens> BuscarPorId(int Id)
        {
            return _itemService.BuscarPorId(Id);
        }
    }
}
