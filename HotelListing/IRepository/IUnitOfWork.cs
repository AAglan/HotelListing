using HotelListing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
   public interface IUnitOfWork : IDisposable
    {
        IGenricRepository<Country> Countries { get; }
        IGenricRepository<Hotel> Hotels { get; }

        Task Save();

    }
}
