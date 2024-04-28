using Microsoft.JSInterop;
using PetScanner.Models;
using PetScanner.Models.DTO;
using System.Collections.Immutable;
using System.IO.Ports;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PetScanner.Services;

public class LocalStorageService
{
    private readonly IJSRuntime jsRuntime;

    public LocalStorageService( IJSRuntime jsRuntime)
    {
        this.jsRuntime = jsRuntime;
    }

    public async Task<string> GetScanHistory()
    {
        var scanHistory = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "ScanHistory");

        return scanHistory;
    }

    public async Task SetScanHistory()
    {
        await jsRuntime.InvokeVoidAsync("localStorage.setItem", "ScanHistory", "");
    }

    public async Task SetNewItemsToScanHistory()
    {
        await jsRuntime.InvokeVoidAsync("localStorage.setItem", "ScanHistory", "");
    }


}

