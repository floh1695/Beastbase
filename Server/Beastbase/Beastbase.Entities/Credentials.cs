using LinqToDB.Mapping;
using System;

namespace Beastbase.Entities
{
    [Table]
	public class Credentials
	{
        [PrimaryKey, Identity]
		public Guid Id { get; set; }

        [Column, NotNull]
		public string Hash { get; set; }
        [Column, NotNull]
		public string Salt { get; set; }
	}
}
