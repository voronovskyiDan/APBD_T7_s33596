using APBD_T7_s33596.Application.Dto;
using APBD_T7_s33596.Application.Interfaces;
using APBD_T7_s33596.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_T7_s33596.Presentation.Controllers
{
    [ApiController]
    [Route("api/pcs")]
    public class PcController : ControllerBase
    {
        private readonly IPcService _pcService;
        public PcController(IPcService pcService)
        {
            _pcService = pcService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pcs = await _pcService.GetAll();
            return Ok(pcs);
        }

        [HttpGet("{id:int}/components")]
        public async Task<IActionResult> GetAllComponentsByPcId(int id)
        {
            var components = await _pcService.GetAllComponentsByPcId(id);
            if (components == null)
                return NotFound();
            return Ok(components);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddPcRequest request)
        {
            var pc = await _pcService.Create(request);

            return CreatedAtAction(nameof(GetAll), new { id = pc.Id }, pc);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, PutPcRequst request)
        {
            var pc = await _pcService.Update(id, request);
            if (pc == null)
                return NotFound();

            return Ok(pc);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _pcService.Delete(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
