using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Services
{
    public interface IClienteService
    {
        Task<Cliente> GetAsync(int Id);
        Task<bool> AddAsync(Cliente cliente);
        Task<bool> DeleteAsync(int Id);
        Task<bool> UpdateAsync(Cliente cliente);
        Task<IEnumerable<Cliente>> GetAllAsync();
    }
}

