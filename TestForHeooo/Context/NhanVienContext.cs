using Microsoft.EntityFrameworkCore;
using TestForHeooo.Models;

namespace TestForHeooo.Context
{
	public class NhanVienContext : DbContext
	{
		
		public NhanVienContext(DbContextOptions options) : base(options)
		{
			//_configuration = configuration;


		}
		//danh sach cac b ghi o trong db
		public DbSet<NhanVien> NhanViens { get; set; }
	
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//object value = optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectionString.DefaultConnection"));
		}
	}
}