using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab2
{
	internal class AnGiContext: DbContext
	{
		public DbSet<MonAn> MonAns { get; set; }
		public DbSet<NguoiDung> NguoiDungs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlite("Data Source=AnGi.db");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<NguoiDung>().HasData(
				new NguoiDung { IDND = 1, HoVaTen = "Cheese" }
			);
			modelBuilder.Entity<MonAn>().HasData(
				new MonAn { IDMA = 1, TenMonAn = "Phở"},
				new MonAn { IDMA = 2, TenMonAn = "Bún" }
			);
		}
	}
}
