using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Species
	{
		public Guid Id { get; set; }

		public virtual ICollection<Animal> Animals { get; set; }
	}
}
