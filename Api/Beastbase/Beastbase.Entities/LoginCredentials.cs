using LinqToDB.Mapping;
using System;

namespace Beastbase.Entities
{
    [Table]
	public class LoginCredentials
	{
        [PrimaryKey, Identity]
		public Guid PersonId { get; set; }
		public virtual Person Person { get; set; }

        [Column, NotNull]
		public Guid CredentialsId { get; set; }
		public virtual Credentials Credentials { get; set; }

        [Column, NotNull]
		public string Username { get; set; }
	}
}
