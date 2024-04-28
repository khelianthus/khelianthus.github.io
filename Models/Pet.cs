using PetScanner.Models.DTO;

namespace PetScanner.Models;

/// <summary>
/// To be used with wl-134 module mapping ScanResponses to history and id to pet.Id.
/// </summary>
public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ScanResponse> ScanHistory { get; set; } = new List<ScanResponse>();
}
