using System;

namespace Beastbase.Entities
{
	public class Entry
	{
		public Guid Id { get; set; }

		public Guid ReportId { get; set; }
		public virtual Report Report { get; set; }

		public Guid ReporterId { get; set; }
		public virtual Person Reporter { get; set; }
	}
}
