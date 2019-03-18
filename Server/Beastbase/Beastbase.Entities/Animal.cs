using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Animal
	{
		public Guid Id { get; set; }

		public Guid SpeciesId { get; set; }
		public virtual Species Species { get; set; }

		public string Name { get; set; }

		public virtual ICollection<Report> Reports { get; set; }
	}
}
