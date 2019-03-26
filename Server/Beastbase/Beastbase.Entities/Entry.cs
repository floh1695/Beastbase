using LinqToDB.Mapping;
using System;

namespace Beastbase.Entities
{
    [Table]
	public class Entry
	{
        [PrimaryKey, Identity]
		public Guid Id { get; set; }

        [Column, NotNull]
		public Guid ReportId { get; set; }
		public virtual Report Report { get; set; }

        [Column, NotNull]
		public Guid ReporterId { get; set; }
		public virtual Person Reporter { get; set; }
	}
}
