using System.ComponentModel.DataAnnotations;

namespace EFDemoProject.ViewModels
{
	public class IssueCreateModel
	{
		[Display(Name = "Название")]
		public string Title { get; set; }

		[Display(Name = "Описание")]
		public string Description { get; set; }

		[Display(Name = "Цена")]
		public double Price { get; set; }
	}
}