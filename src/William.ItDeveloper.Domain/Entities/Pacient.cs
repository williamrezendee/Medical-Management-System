using William.ItDeveloper.Domain.Enums;

namespace William.ItDeveloper.Domain.Entities
{
	public class Pacient
	{
        public Pacient() { Active = true; }

        public Guid PacientStatusId { get; set; }
        public virtual PacientStatus? PacientStatus { get; set; }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HospitalizationDate { get; set; }
        public string? Email { get; set; }
        public bool Active { get; set; }
        public string? Cpf { get; set; }
        public PacientType PacientType { get; set; }
        public Gender Gender { get; set; }
        public string? Rg { get; set; }
        public string? RgAgency { get; set; }
        public DateTime RgDateOfIssue { get; set; }
        public string? Motive { get; set; }

		public override string ToString()
		{
			return Id.ToString() + " - " + Name;
		}
	}
}
