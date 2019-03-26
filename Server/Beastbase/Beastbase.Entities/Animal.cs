using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
    [Table]
	public class Animal
	{
        [PrimaryKey, Identity]
		public Guid Id { get; set; }

        [Column, NotNull]
		public Guid SpeciesId { get; set; }
		public virtual Species Species { get; set; }

        [Column, NotNull]
		public string Name { get; set; }

		public virtual ICollection<Report> Reports { get; set; }
	}
}
