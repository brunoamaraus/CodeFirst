using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public interface IDataAccessProvider
    {
       
        Task<List<Pessoa>> GetListaPessoaAsync();
        Task<Pessoa> GetPessoaId(int id);
    }
}
