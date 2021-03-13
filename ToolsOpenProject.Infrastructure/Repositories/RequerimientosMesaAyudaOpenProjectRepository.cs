using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsOpenProject.Domain.Entities;
using ToolsOpenProject.Domain.Repositories;

namespace ToolsOpenProject.Infrastructure.Repositories
{
    public class RequerimientosMesaAyudaOpenProjectRepository : IRequerimientosMesaAyudaOpenProjectRepository
    {
        private readonly ToolsMesaAyudaContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public RequerimientosMesaAyudaOpenProjectRepository(ToolsMesaAyudaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<RequerimientosMesaAyudaOpenProject>> GetAsync()
        {
            return await _context
                .RequerimientosMesaAyudaOpenProjects
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<RequerimientosMesaAyudaOpenProject> GetAsync(int id)
        {
            var item = await _context.RequerimientosMesaAyudaOpenProjects
                 .AsNoTracking()
                 .Where(x => x.Id == id).FirstOrDefaultAsync();

            return item;
        }

        public RequerimientosMesaAyudaOpenProject Add(RequerimientosMesaAyudaOpenProject record)
        {
            return _context.RequerimientosMesaAyudaOpenProjects.Add(record).Entity;
        }

        public RequerimientosMesaAyudaOpenProject Update(RequerimientosMesaAyudaOpenProject record)
        {
            _context.Entry(record).State = EntityState.Modified;
            return record;
        }
        public async Task<int> SetRequerimientosFromJson(string json){

            return await _context.Database.ExecuteSqlRawAsync("SELECT set_requerimientos_from_json({0})", json);
        }
    }
}
