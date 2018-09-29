using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repository;

        public ServiceBase(IRepositorioBase<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public TEntity GetById(int Id)
        {
            return _repository.GetById(Id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
