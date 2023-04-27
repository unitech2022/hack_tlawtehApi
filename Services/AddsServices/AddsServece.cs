using System.Text.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HackTlawtehApi.Data;
using HackTlawtehApi.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using X.PagedList;

namespace HackTlawtehApi.Serveries.CategoriesServices
{
    public class AddsService : IAddsService

    {


        private readonly IMapper _mapper;


        private readonly AppDBcontext _context;

        public AddsService(IMapper mapper, AppDBcontext context)
        {
            _mapper = mapper;

            _context = context;
        }

        public async Task<Add> AddADD(Add add)
        {
            await _context.Adds!.AddAsync(add);

            await _context.SaveChangesAsync();

            return add;
        }

        public async Task<Add> DeleteAdd(int AddId)
        {
            Add? add = await _context.Adds!.FirstOrDefaultAsync(x => x.Id == AddId);

            if (add != null)
            {
                _context.Adds!.Remove(add);

                await _context.SaveChangesAsync();
            }

            return add!;
        }

        public async Task<object> GetAdds()
        {
            var adds = await _context.Adds!.ToListAsync();
            return adds;
        }

        public Task<Add> GitAddById(int AddId)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAdd(Add Add)
        {
            throw new NotImplementedException();
        }
    }
}