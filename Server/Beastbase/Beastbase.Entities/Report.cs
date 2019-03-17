using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Report
	{
		public int Id { get; set; }

		public int AnimalId { get; set; }
		public virtual Animal Animal { get; set; }

		public int ReporterId { get; set; }
		public virtual Person Reporter { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
	}
}
