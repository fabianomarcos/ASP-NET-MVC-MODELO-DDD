using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class NfRepositorio : RepositorioBase<NFs>, INfsRepositorio
    {
        public IEnumerable<NFs> BuscarPorNome(int nome)
        {
            return Db.NFs.Where(p => p.Numero == nome);
        }
    }
}
