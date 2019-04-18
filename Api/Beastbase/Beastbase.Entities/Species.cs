using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
    [Table]
	public class Species
	{
        [PrimaryKey, Identity]
		public Guid Id { get; set; }

        [Column, NotNull]
		public string Name { get; set; }

		public virtual ICollection<Animal> Animals { get; set; }
	}
}
