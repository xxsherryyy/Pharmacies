using Pharmacies.Contracts.PharmaciesList;

namespace Pharmacies.Models;

public class Pharmacy
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public int Zip { get; set; }
    public int FilledPrescriptions { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public Pharmacy(
        Guid id,
        string name,
        string address,
        string city,
        string state,
        int zip,
        int filledPrescriptions,
        DateTime createdDate,
        DateTime updatedDate
    )
    {
        Id = id;
        Name = name;
        Address = address;
        City = city;
        State = state;
        Zip = zip;
        FilledPrescriptions = filledPrescriptions;
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
    }

        public static Pharmacy Create(
            string name,
            string address,
            string city,
            string state,
            int zip,
            int filledPrescriptions,
            DateTime createdDate,
            DateTime updatedDate,
            Guid? id = null)
        {

            return new Pharmacy( //object is initialized line 7
                id ?? Guid.NewGuid(),
                name,
                address,
                city,
                state,
                zip,
                filledPrescriptions,
                createdDate,
                updatedDate);
        }

        public static Pharmacy From(GetPharmaciesResponse request)
        {
            return Create(
                request.Name,
                request.Address,
                request.City,
                request.State,
                request.Zip,
                request.FilledPrescriptions,
                request.CreatedDate,
                request.UpdatedDate);
        }
        public static Pharmacy From(CreatePharmaciesListRequest request)
        {
            return Create(
                request.Name,
                request.Address,
                request.City,
                request.State,
                request.Zip,
                request.FilledPrescriptions,
                request.CreatedDate,
                request.UpdatedDate);
        }

        public static Pharmacy From(Guid id, UpsertPharmaciesListRequest request)
        {
            return Create(
                request.Name,
                request.Address,
                request.City,
                request.State,
                request.Zip,
                request.FilledPrescriptions,
                request.CreatedDate,
                request.UpdatedDate,
                id);
        }
}