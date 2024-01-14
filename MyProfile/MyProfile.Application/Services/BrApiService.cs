using MyProfile.Application.Interfaces;
using MyProfile.Application.Responses;
using MyProfile.Shared;
using RestSharp;

namespace MyProfile.Application.Services;

public class BrApiService : IBrApiService
{
    public void GetAllBdrs(string token, string sortBy = null, string sortOrder = null, string limit = null, string page = null, string sector = null, string search = null, CancellationToken cancellationToken = default)
    {

    }

    public async Task<BrApiFundsResponse> GetAllFundsAsync(string token, string sortBy = null, string sortOrder = null, string limit = null, string page = null, string sector = null, string search = null, CancellationToken cancellationToken = default)
    {
        var client = new RestClient();
        var request = new RestRequest(MyProfileSettings.GetInstance().BrApi);

        var response = await client.GetAsync<BrApiFundsResponse>(request, cancellationToken);

        return response;
    }

    public void GetAllStocks(string token, string sortBy = null, string sortOrder = null, string limit = null, string page = null, string sector = null, string search = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
