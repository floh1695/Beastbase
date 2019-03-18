using System;

namespace Beastbase.Entities
{
	public class LoginCredentials
	{
		public Guid PersonId { get; set; }
		public virtual Person Person { get; set; }

		public Guid CredentialsId { get; set; }
		public virtual Credentials Credentials { get; set; }

		public string Username { get; set; }
	}
}
