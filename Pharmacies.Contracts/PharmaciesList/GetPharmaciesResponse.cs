namespace Pharmacies.Contracts.PharmaciesList;

public record GetPharmaciesResponse(
    Guid Id,
    string Name,
    string Address,
    string City,
    string State,
    int Zip,
    int FilledPrescriptions,
    DateTime CreatedDate,
    DateTime UpdatedDate
);