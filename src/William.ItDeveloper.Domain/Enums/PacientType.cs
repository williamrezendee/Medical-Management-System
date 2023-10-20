using System.ComponentModel;

namespace William.ItDeveloper.Domain.Enums
{
	public enum PacientType
	{
		[Description("Partner")] Partner = 1,
		[Description("Private")] Private = 2,
		[Description("Others")] Others = 3
	}
}
