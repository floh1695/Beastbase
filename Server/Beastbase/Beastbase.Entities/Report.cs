using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Report
	{
		public Guid Id { get; set; }

		public Guid AnimalId { get; set; }
		public virtual Animal Animal { get; set; }

		public Guid ReporterId { get; set; }
		public virtual Person Reporter { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
	}
}
