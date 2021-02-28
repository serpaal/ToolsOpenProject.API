using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Entities;
using ToolsOpenProject.Domain.Repositories;

namespace ToolsOpenProject.Infrastructure.Repositories
{
    public class MesaAyudaOpenProjectRepository : IMesaAyudaOpenProjectRepository
    {
        private readonly ToolsMesaAyudaContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public MesaAyudaOpenProjectRepository(ToolsMesaAyudaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<MesaAyudaOpenProject>> GetAsync()
        {
            return await _context
                .MesaAyudaOpenProjects
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<MesaAyudaOpenProject> GetAsync(int id)
        {
            var item = await _context.MesaAyudaOpenProjects
                 .AsNoTracking()
                 .Where(x => x.Id == id).FirstOrDefaultAsync();

            return item;
        }

        public MesaAyudaOpenProject Add(MesaAyudaOpenProject record)
        {
            return _context.MesaAyudaOpenProjects.Add(record).Entity;
        }

        public MesaAyudaOpenProject Update(MesaAyudaOpenProject record)
        {
            _context.Entry(record).State = EntityState.Modified;
            return record;
        }
    }
}
