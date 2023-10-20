using Microsoft.AspNetCore.Mvc;

namespace William.ItDeveloper.Mvc.Controllers
{
	[Route("")]
	[Route("pacient-management")]
	[Route("pacients-management")]
	public class PacientController : BaseController
	{
		//[HttpGet("")]
		[Route("pacients")]
		[Route("get-pacients")]
		public IActionResult Index()
		{
			var pacients = GetPacients();

			return View(pacients);
		}

		[Route("pacient-detail/{id}")]
		public IActionResult PacientDetail(string id)
		{
			var pacient = GetPacient(id);
			if (pacient == null) return NotFound();
			return View(pacient);
		}

		//[Route("add-pacient")]
		[HttpPost("add-pacient")]
		public IActionResult AddPacient()
		{
			return View();
		}

		#region: Pacients' list
		private List<Pacient> GetPacients()
		{
			var pacients = new List<Pacient>()
			{
				new Pacient
				{
					Name = "Anne Natalie Silva Rezende",
					Cpf = "75865419538",
					Phones = new List<Phone>()
					{
						new Phone { Id = Guid.NewGuid(), PhoneType = "Personal", Number = "79991147582" },
						new Phone { Id = Guid.NewGuid(), PhoneType = "Work", Number = "79998524638" },
					}
				},
				new Pacient
				{
					Name = "Eloá Silva Rezende",
					Cpf = "04526802599",
					Phones = new List<Phone>()
					{
						new Phone { Id = Guid.NewGuid(), PhoneType = "Personal", Number = "79986348346" },
						new Phone { Id = Guid.NewGuid(), PhoneType = "Work", Number = "79991175216" },
					}
				},
				new Pacient
				{
					Name = "Andrew Nicholas Rezende",
					Cpf = "25845675322",
					Phones = new List<Phone>()
					{
						new Phone { Id = Guid.NewGuid(), PhoneType = "Personal", Number = "79996358246" },
						new Phone { Id = Guid.NewGuid(), PhoneType = "Work", Number = "79998475216" },
					}
				},
			};

			return pacients;
		}

		private Pacient? GetPacient(string id)
		{
			var pacients = GetPacients();
			if (id != String.Empty && pacients != null)
			{
				var pacient = pacients.FirstOrDefault(p => p.Name.Contains(id));
				if (pacient != null)
				{
					return pacient;
				}
			}
			return null;
		}
		#endregion
	}

	public class Pacient
	{
        public Pacient()
        {
            Id = Guid.NewGuid();
			Phones = new HashSet<Phone>();

        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }

	public class Phone
	{
		public Guid Id { get; set; }
        public string? PhoneType { get; set; }
        public string? Number { get; set; }
    }

}
