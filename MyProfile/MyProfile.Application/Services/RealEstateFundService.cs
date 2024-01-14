using MyProfile.Application.Interfaces;
using MyProfile.Domain.Entities;
using MyProfile.Infra.Data.Interfaces;
using MyProfile.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProfile.Application.Services;

public class RealEstateFundService : IRealEstateFundService
{
    private readonly IRealEstateFundRepository _realEstateFundRepository;

    public RealEstateFundService(IRealEstateFundRepository realEstateFundRepository)
    {
        _realEstateFundRepository = realEstateFundRepository;
    }

    public async Task Save(RealEstateFund realEstateFund)
    {
        await _realEstateFundRepository.Save(realEstateFund);
    }
}
