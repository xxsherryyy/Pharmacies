namespace Pharmacies.Contracts.PharmaciesList;

public record UpsertPharmaciesListRequest(
    Guid id,
    string Name,
    string Address,
    string City,
    string State,
    int Zip,
    int FilledPrescriptions,
    DateTime CreatedDate,
    DateTime UpdatedDate
);