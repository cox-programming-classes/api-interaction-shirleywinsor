global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Models;
using CS8_MessageAPI.Services;

// This is your Postman Analog
var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("shirley.yang@winsor.edu", "Shirleyy123",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;

var myFreeBlocks = await apiService.SendAsync<FreeBlockCollection>(HttpMethod.Get, "api/schedule/free-blocks/for/",
    err =>
    {
        Console.WriteLine(err);
    })
    
Console.WriteLine($"jwt: {apiService.AuthorizedUser?.jwt}");

var b64String = Convert.FromBase64String(apiService.AuthorizedUser?.jwt ?? "");

Console.WriteLine(b64String);