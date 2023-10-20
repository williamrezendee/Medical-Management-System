using System.ComponentModel.DataAnnotations;
using William.ItDeveloper.Domain.Entities;
using William.ItDeveloper.Domain.Enums;

namespace William.ItDeveloper.Mvc.Models
{
	public class PacientViewModel
	{
		public Guid PacientStatusId { get; set; }
		public virtual PacientStatus? PacientStatus { get; set; }

		[Key]
		public Guid Id { get; set; }
		public string? Name { get; set; }

		[Display(Name = "Birth Date")]
		[DataType(DataType.DateTime, ErrorMessage = "The {0} is invalid.")]
		public DateTime BirthDate { get; set; }

		[Display(Name = "Hospitalization Date")]
		[DataType(DataType.DateTime, ErrorMessage = "The {0} is invalid.")]
		public DateTime HospitalizationDate { get; set; }
		public string? Email { get; set; }
		public bool Active { get; set; }
		public string? Cpf { get; set; }
		public PacientType PacientType { get; set; }
		public Gender Gender { get; set; }
		public string? Rg { get; set; }
		public string? RgAgency { get; set; }

		[Display(Name = "Date of Issue")]
		[DataType(DataType.DateTime, ErrorMessage = "The {0} is invalid.")]
		public DateTime RgDateOfIssue { get; set; }
		public string? Motive { get; set; }

		public override string ToString()
		{
			return Id.ToString() + " - " + Name;
		}
	}
}
