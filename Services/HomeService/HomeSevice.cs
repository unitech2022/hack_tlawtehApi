using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HackTlawtehApi.Data;
using HackTlawtehApi.Models;
using HackTlawtehApi.ViewModel;
using HackTlawtehApi.ViewModels;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace HackTlawtehApi.Services.HomeSevice
{
    public class HomeService : IHomeService
    {

        private readonly IMapper _mapper;


        private readonly AppDBcontext _context;

        public HomeService(IMapper mapper, AppDBcontext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public async Task<HomeUserResponse> GetHomeUser(string country, string UserId)
        {

            var user = await _context.Users.FirstOrDefaultAsync(t => t.Id == UserId);
            List<Category> categories = await _context.Categories!.ToListAsync();
            List<Teacher> teachers = await _context.Teachers!.Where(t => t.Country == country).ToListAsync();
            UserDetailResponse? userDetail = _mapper.Map<UserDetailResponse>(user);
                        List<Add> adds = await _context.Adds!.Where(t=> t.Status==1).ToListAsync();


            HomeUserResponse homeUserResponse = new HomeUserResponse
            {
                Teachers = teachers,
                Categories = categories,
                UserDetail = userDetail,

                Adds=adds
            };


            return homeUserResponse;
        }
    }
}