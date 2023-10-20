namespace William.ItDeveloper.Mvc.Models
{
	public class PacientStatusViewModel
	{
		public Guid Id { get; set; }
		public string? Description { get; set; }
		public virtual ICollection<Pacient>? Pacients { get; set; }
	}
}
