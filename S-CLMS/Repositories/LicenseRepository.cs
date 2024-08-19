using Microsoft.EntityFrameworkCore;
using S_CLMS.Data;
using S_CLMS.Models;

namespace S_CLMS.Repositories
{
    public class LicenseRepository: ILicenseRepository
    {
        private readonly SclmsContext _context;

        public LicenseRepository(SclmsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<License>> GetLicensesAsync()
        {
            return await _context.Licenses.ToListAsync();
        }
        public async Task<License> GetLicenseByIdAsync(int id)
        {
            return await _context.Licenses.FindAsync(id);
        } 
        public async Task AddLicenseAsync(License license)
        {
            _context.Licenses.Add(license);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLicenseAsync(int id)
        {
            var license = await _context.Licenses.FindAsync(id);
            _context.Licenses.Remove(license);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLicenseAsync(License license)
        {
            _context.Licenses.Update(license);
            await _context.SaveChangesAsync();
        }
    }
}
