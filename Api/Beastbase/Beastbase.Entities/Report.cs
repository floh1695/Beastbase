using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
    [Table]
	public class Report
	{
        [PrimaryKey, Identity]
		public Guid Id { get; set; }

        [Column, NotNull]
		public Guid AnimalId { get; set; }
		public virtual Animal Animal { get; set; }

        [Column, NotNull]
		public Guid ReporterId { get; set; }
		public virtual Person Reporter { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
	}
}
