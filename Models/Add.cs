using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTlawtehApi.Models
{
    public class Add
    {
        public int Id { get; set; }

        public string? Image { get; set; }
        public string? Desc { get; set; }
        public string? Connect { get; set; }
        public int Status { get; set; }

        public DateTime? ExpiredAt { get; set; }

        public DateTime? CreatedAt { get; set; }
        public Add() {
            CreatedAt = DateTime.UtcNow.AddHours(3);
               ExpiredAt = DateTime.UtcNow.AddHours(20);
            Status =0;
         
           


        }
    }
}