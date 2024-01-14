using MyProfile.Domain.Entities;

namespace MyProfile.Infra.Data.Interfaces;

public interface IRealEstateFundRepository
{
    Task Save(RealEstateFund realEstateFund);
}
