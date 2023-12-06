using Pharmacies.Contracts.PharmaciesList;
using Pharmacies.Dtos;
using Pharmacies.Models;

namespace Pharmacies.Services.Pharmacies;

public class PharmaciesService : IPharmaciesService
{
    private static readonly Dictionary<Guid, Pharmacy> _pharmacies = new();

    public async Task<Pharmacy> CreatePharmacy(Pharmacy pharmacies)
    {

        try
        {
            await Task.Run(() =>
            {
                _pharmacies.Add(pharmacies.Id, pharmacies);
            });

            return pharmacies;
        }
        catch (Exception ex)
        {
             // Fix: Add error handling
            throw;
        }

    }


    public async Task<List<Pharmacy>> GetPharmacies()
    {
        var response = new List<Pharmacy>();
        await Task.Run(() =>
        {
            foreach (var pharmacy in _pharmacies.Values)
            {
                response.Add(pharmacy);
            }
        });
        return response;
    }

    public async Task<Pharmacy> UpsertPharmacy(Pharmacy pharmacies)
    {

        await Task.Run(() =>
        {
            if (_pharmacies.ContainsKey(pharmacies.Id))
            {
                _pharmacies[pharmacies.Id] = pharmacies;
            }

        });

        return pharmacies;
    }
}