namespace Pharmacies.Contracts.PharmaciesList;

public record CreatePharmaciesListRequest(
    string Name,
    string Address,
    string City,
    string State,
    int Zip,
    int FilledPrescriptions,
    DateTime CreatedDate,
    DateTime UpdatedDate
);