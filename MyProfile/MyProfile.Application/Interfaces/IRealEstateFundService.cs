using MyProfile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProfile.Application.Interfaces;

public interface IRealEstateFundService
{
    Task Save(RealEstateFund realEstateFund);
}
