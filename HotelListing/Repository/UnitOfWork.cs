using HotelListing.Data;
using HotelListing.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;

        private IGenricRepository<Country> _countries;
        private IGenricRepository<Hotel> _hotels;
        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }

        public IGenricRepository<Country> Countries => _countries ??= new GenricRepository<Country>(_context);

        public IGenricRepository<Hotel> Hotels => _hotels ??= new GenricRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();   
        }
    }
}
