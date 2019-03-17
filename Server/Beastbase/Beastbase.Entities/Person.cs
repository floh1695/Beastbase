using System.Collections.Generic;

namespace Beastbase.Entities
{
	public class Person
	{
		public int Id { get; set; }

		public int CredentialsId { get; set; }
		public virtual Credentials Credentials { get; set; }

		public virtual ICollection<Report> Reports { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
	}
}
