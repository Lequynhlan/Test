using System.ComponentModel.DataAnnotations;

namespace TestForHeooo.Models
{
	public class NhanVien
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string CompanyName { get; set; }
		[Required]
		public string Designation { get; set; }

	}
}
