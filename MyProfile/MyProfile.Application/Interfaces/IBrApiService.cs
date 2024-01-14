using MyProfile.Application.Responses;

namespace MyProfile.Application.Interfaces;

public interface IBrApiService
{
    void GetAllStocks(
        string token,
        string sortBy = null,
        string sortOrder = null,
        string limit = null,
        string page = null,
        string sector = null,
        string search = null,
        CancellationToken cancellationToken = default
    );

    Task<BrApiFundsResponse> GetAllFundsAsync(
        string token,
        string sortBy = null,
        string sortOrder = null,
        string limit = null,
        string page = null,
        string sector = null,
        string search = null,
        CancellationToken cancellationToken = default
    );

    void GetAllBdrs(
        string token,
        string sortBy = null,
        string sortOrder = null,
        string limit = null,
        string page = null,
        string sector = null,
        string search = null,
        CancellationToken cancellationToken = default
    );
}
