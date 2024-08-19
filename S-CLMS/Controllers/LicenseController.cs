using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S_CLMS.Models;
using S_CLMS.Repositories;

namespace S_CLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LicenseController : ControllerBase
    {
        private readonly ILicenseRepository _licenseRepository;

        public LicenseController(ILicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLicense()
        {
            return Ok(await _licenseRepository.GetLicensesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLicenseById(int id)
        {
            return Ok(await _licenseRepository.GetLicenseByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddLicense(License license)
        {
            await _licenseRepository.AddLicenseAsync(license);
            return CreatedAtAction(nameof(GetLicenseById), new { id = license.LicenseId }, license);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLicense(int id, License license)
        {
            if (id != license.LicenseId) return BadRequest();
            await _licenseRepository.UpdateLicenseAsync(license);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLicense(int id)
        {
            await _licenseRepository.DeleteLicenseAsync(id);
            return NoContent();
        }
    }
}
