using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Animal
	{
		public int Id { get; set; }

		public int SpeciesId { get; set; }
		public virtual Species Species { get; set; }

		public virtual ICollection<Report> Reports { get; set; }
	}
}
