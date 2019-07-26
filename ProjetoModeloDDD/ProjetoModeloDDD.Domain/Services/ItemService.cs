using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ItemService : ServiceBase<Itens>, IItemService
    {
        private readonly IItensRepositorio _itemRepository;

        public ItemService(IItensRepositorio itemRepositorio)
            :base(itemRepositorio)
        {
            _itemRepository = itemRepositorio;
        }

        public IEnumerable<Itens> BuscarPorId(int ItemId)
        {
            return _itemRepository.BuscarPorId(ItemId);
        }
    }
}
