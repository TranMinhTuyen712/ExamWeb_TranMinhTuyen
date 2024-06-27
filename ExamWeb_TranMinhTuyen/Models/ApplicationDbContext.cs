using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_TranMinhTuyen.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Phim> Phim { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data to table Categories
            modelBuilder.Entity<Phim>().HasData(
            new Phim { Id = 1, TuaDe = "Chúng ta của 8 năm sau", TrongNuoc = true, GiaVe = 150.000, ThoiLuong = 110 },
            new Phim { Id = 2, TuaDe = "Avatar", TrongNuoc = true, GiaVe = 150.000, ThoiLuong = 110 },
            new Phim { Id = 3, TuaDe = "Gặp em ngày nắng", TrongNuoc = true, GiaVe = 150.000, ThoiLuong = 110 },
            new Phim { Id = 4, TuaDe = "Không ngại cười", TrongNuoc = true, GiaVe = 150.000, ThoiLuong = 110 },
            new Phim { Id = 5, TuaDe = "Gia đình đại chiến", TrongNuoc = true, GiaVe = 150.000, ThoiLuong = 110 },
            new Phim { Id = 6, TuaDe = "Kẻ huỷ diệt", TrongNuoc = true, GiaVe = 150.000, ThoiLuong = 110 });

            //seed data to table Product

        }
    }
}
