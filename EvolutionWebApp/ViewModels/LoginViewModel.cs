using System.ComponentModel.DataAnnotations;

namespace EvolutionWebApp.ViewModels
{
	public class LoginViewModel
	{
		[Required]
		public string User { get; set; } = null!;

		[Required]
		public string Password { get; set; } = null!;
	}
}
