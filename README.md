# Pharmacies API (WIP)
-Currently there's bug/reference error that prevents it from building

# To get started 
-Run .Net 7 SDK
`dotnet build` 
`dotnet run --project .\Pharmacies\`

-Pharmacies Route 

GET /api/pharmacies/list
POST /api/pharmacies/
PUT /api/pharmacies/{id} 


-API Controller
  - CreatePharmacy() - Create new pharmacy
  - GetPharacy() - Get Pharmacies list
  - UpsertPharmacyList() - Update a Pharmacy


Business Logic
  - Pharmacies.Services.Pharmacies

 
Database Contract
  - Pharmacies.Contracts.Pharmacies
