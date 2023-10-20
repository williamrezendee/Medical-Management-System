namespace William.ItDeveloper.Domain.Entities
{
	public class PacientStatus
	{
		public Guid Id { get; set; }
		public string? Description { get; set; }
        public virtual ICollection<Pacient>? Pacients { get; set; }
    }
}
