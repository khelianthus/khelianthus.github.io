using System.Text.Json.Serialization;

namespace PetScanner.Models.DTO;


public class ScanResponse
{
    [JsonPropertyName("scans")]
    public List<TimeResponse> Scans { get; set; }
}


/// <summary>
/// To be used when wl-134 module is scanning id
/// </summary>
//public class ScanResponse
//{
//    [JsonPropertyName("id")]
//    public int Id { get; set; }

//    [JsonPropertyName("time")]
//    public int Time { get; set; }
//}
