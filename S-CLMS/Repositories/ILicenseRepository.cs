using S_CLMS.Models;

namespace S_CLMS.Repositories
{
    public interface ILicenseRepository
    {
        Task<IEnumerable<License>> GetLicensesAsync();
        Task<License> GetLicenseByIdAsync(int id);
        Task AddLicenseAsync(License license);
        Task UpdateLicenseAsync(License license);
        Task DeleteLicenseAsync(int id);
    }
}
