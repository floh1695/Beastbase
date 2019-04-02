using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
    [Table]
	public class Person
	{
        [PrimaryKey, Identity]
		public Guid Id { get; set; }

        [Column, NotNull]
		public string Name { get; set; }

		public LoginCredentials LoginCredentials { get; set; }

		public virtual ICollection<Report> Reports { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
	}
}
