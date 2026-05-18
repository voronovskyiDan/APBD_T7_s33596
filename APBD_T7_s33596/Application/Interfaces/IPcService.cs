using APBD_T7_s33596.Application.Dto;
using APBD_T7_s33596.Domain.Models;

namespace APBD_T7_s33596.Application.Interfaces
{
    public interface IPcService
    {
        public Task<List<PcResponseDto>> GetAll();
        public Task<List<ComponentResponseDto>?> GetAllComponentsByPcId(int id);
        public Task<PcResponseDto> Create(AddPcRequest dto);
        public Task<PcResponseDto?> Update(int id, PutPcRequst dto);
        public Task<bool> Delete(int id);
    }
}
