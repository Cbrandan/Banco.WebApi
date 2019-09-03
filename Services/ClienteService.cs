using Banco.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ApplicationDbContext _context;
        public ClienteService(ApplicationDbContext context)
        {
            _context = context;

            if (!_context.Clientes.Any())
                {
                _context.AddRange(Enumerable.Range(1, 20).Select(
                    i => new Cliente()
                    {
                        Nombre = "Nombre " + i,
                        Apellido = "Apellido " + i,
                        FechaAlta = DateTime.Now,
                        FechaNacimiento = DateTime.Now.AddYears(-i)

                    }
                    )
                    );

                _context.SaveChanges();


                }

        }

        public async Task<bool> AddAsync(Cliente cliente)
        {
            cliente.FechaAlta = DateTime.Now;
            _context.Clientes.Add(cliente);
            var res = await _context.SaveChangesAsync();
            if (res == 1)
                return true;
            else
                return false;
                 
        }

        public Task<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetAsync(int Id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(f => f.Id == Id);

        }

        public Task<bool> UpdateAsync(Cliente cliente)
        {
            throw new NotImplementedException();
            //_context.Clientes.Update(false => false.i)
        }
    }
}
