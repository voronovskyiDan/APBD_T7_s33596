using APBD_T7_s33596.Application.Dto;
using APBD_T7_s33596.Application.Interfaces;
using APBD_T7_s33596.Domain.Models;
using APBD_T7_s33596.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APBD_T7_s33596.Application.Services
{
    public class PcService : IPcService
    {
        //I know its bettr to create a repository =)
        //But in this context it wasn`t necessary
        private readonly AppDbContext _dbContext;
        public PcService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PcResponseDto> Create(AddPcRequest dto)
        {
            var pc = new PC
            {
                Name = dto.Name,
                Weight = dto.Weight,
                Warranty = dto.Warranty,
                CreatedAt = dto.CreatedAt!.Value,
                Stock = dto.Stock
            };

            _dbContext.PCs.Add(pc);
            await _dbContext.SaveChangesAsync();

            var response = new PcResponseDto
            {
                Id = pc.Id,
                Name = pc.Name,
                Weight = pc.Weight,
                Warranty = pc.Warranty,
                CreatedAt = pc.CreatedAt,
                Stock = pc.Stock
            };
            return response;
        }

        public async Task<bool> Delete(int id)
        {
            var pc = await _dbContext.PCs.FindAsync(id);
            if (pc == null)
                return false;

            _dbContext.PCs.Remove(pc);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<PcResponseDto>> GetAll()
        {
            return await _dbContext.PCs
                .Select(pc => new PcResponseDto
                {
                    Id = pc.Id,
                    Name = pc.Name,
                    Weight = pc.Weight,
                    Warranty = pc.Warranty,
                    CreatedAt = pc.CreatedAt,
                    Stock = pc.Stock
                })
                .ToListAsync();
        }

        public async Task<List<ComponentResponseDto>?> GetAllComponentsByPcId(int id)
        {
            var pc = await _dbContext.PCs
                .Include(p => p.PCComponents)
                .ThenInclude(p => p.Component)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pc == null)
                return null;

            return pc.PCComponents
                .Select(pcc => new ComponentResponseDto
                {
                    Code = pcc.Component.Code,
                    Name = pcc.Component.Name,
                    Description = pcc.Component.Description,
                    Amount = pcc.Amount
                })
                .ToList();
        }

        public async Task<PcResponseDto?> Update(int id, PutPcRequst dto)
        {
            var pc = await _dbContext.PCs.FindAsync(id);
            if (pc == null)
                return null;

            pc.Name = dto.Name;
            pc.Weight = dto.Weight;
            pc.Warranty = dto.Warranty;
            pc.CreatedAt = dto.CreatedAt!.Value;
            pc.Stock = dto.Stock;

            await _dbContext.SaveChangesAsync();
            return new PcResponseDto
            {
                Id = pc.Id,
                Name = pc.Name,
                Weight = pc.Weight,
                Warranty = pc.Warranty,
                CreatedAt = pc.CreatedAt,
                Stock = pc.Stock
            };
        }
    }
}
