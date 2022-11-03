using Microsoft.AspNetCore.Mvc;

namespace TestForHeooo.Controllers
{
	public class NhanVienControlller : Controller
	{
		private readonly IConfiguration _configuration;
		public NhanVienControlller(IConfiguration configuration)
		{
			_configuration = configuration;
		}
	}
}
