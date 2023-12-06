using Pharmacies.Contracts.PharmaciesList;
using Pharmacies.Dtos;
using Pharmacies.Models;
namespace Pharmacies.Services.Pharmacies
{
    public interface IPharmaciesService
    {
        Task<List<Pharmacy>> GetPharmacies();
        Task<Pharmacy> CreatePharmacy(Pharmacy newPharmacy);
        Task<Pharmacy> UpsertPharmacy(Pharmacy pharmacy);
    }
}