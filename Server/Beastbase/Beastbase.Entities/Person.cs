using System;
using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Person
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public LoginCredentials LoginCredentials { get; set; }

		public virtual ICollection<Report> Reports { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
	}
}
