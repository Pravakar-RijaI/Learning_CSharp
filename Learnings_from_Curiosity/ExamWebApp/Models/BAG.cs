using System.ComponentModel.DataAnnotations;

namespace ExamWebApp.Models
{
	public class BAG
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		public string? Brand { get; set; }

		[Required]
		public double Price { get; set; }

		[Required]
		public DateTime Date { get; set; }
	}
}
