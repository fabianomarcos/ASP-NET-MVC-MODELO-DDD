using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ItemService : ServiceBase<Itens>, IItemService
    {
        private readonly IItemRepositorio _itemRepository;

        public ItemService(IItemRepositorio itemRepositorio)
            :base(itemRepositorio)
        {
            _itemRepository = itemRepositorio;
        }

        public IEnumerable<Itens> BuscarPorId(int Id)
        {
            return _itemRepository.BuscarPorId(Id);
        }
    }
}
