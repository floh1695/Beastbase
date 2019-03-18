using System;

namespace Beastbase.Entities
{
	public class Credentials
	{
		public Guid Id { get; set; }

		public string Hash { get; set; }
		public string Salt { get; set; }
	}
}
