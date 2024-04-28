using PetScanner.Models.DTO;

namespace PetScanner.Models;

public class ScanHistory
{
    //To be used with wl-134 module
    public List<ScanResponse> HistoryList { get; set; }

    public List<TimeResponse> TimeList { get; set; }
}


