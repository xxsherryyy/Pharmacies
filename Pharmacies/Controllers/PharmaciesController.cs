using Microsoft.AspNetCore.Mvc;
using Pharmacies.Contracts.PharmaciesList;
using Pharmacies.Models;
using Pharmacies.Services.Pharmacies;

namespace Pharmacies.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PharmaciesController : ControllerBase
{
    private readonly IPharmaciesService _pharmaciesService;

    public PharmaciesController(IPharmaciesService pharmaciesService)
    {
        _pharmaciesService = pharmaciesService;
    }

    [HttpPost]
    public IActionResult CreatePharmacy(Pharmacy request)
    {
        var response = _pharmaciesService.CreatePharmacy(request);
        return Ok(response);
    }

    [HttpGet("list")]
    public IActionResult GetPharmacy() {
        var response = _pharmaciesService.GetPharmacies();
        return Ok(response);
    }

    [HttpPut("{id:guid}")]

    public IActionResult UpsertPharmaciesList(Guid id, UpsertPharmaciesListRequest request) {
        var updatePharmacy = Pharmacy.From(id, request);
        var response = _pharmaciesService.UpsertPharmacy(updatePharmacy);
        
        return Ok(response);
    }

}