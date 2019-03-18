using Beastbase.Entities;
using FluentMigrator;

namespace Beastbase.Migrations
{
	public class Migration001InitializeDatabase : AutoReversingMigration
	{
		public override void Up()
		{
			var nameColumnLength = 255;
			var securityColumnLength = 512;

			CreateAnimalTables(nameColumnLength);
			CreatePersonTables(nameColumnLength);
			CreateLoginTables(nameColumnLength, securityColumnLength);
			CreateReportTables();
		}


		private void CreateAnimalTables(int nameColumnLength)
		{
			CreateSpeciesTable(nameColumnLength);
			CreateAnimalTable(nameColumnLength);
		}

		private void CreateSpeciesTable(int nameColumnLength) =>
			Create
				.Table(nameof(Species))
					.WithColumn(nameof(Species.Id))
						.AsGuid()
						.NotNullable()
						.PrimaryKey()
						.Identity()
					.WithColumn(nameof(Species.Name))
						.AsString(nameColumnLength)
						.NotNullable();

		private void CreateAnimalTable(int nameColumnLength) =>
			Create
				.Table(nameof(Animal))
					.WithColumn(nameof(Animal.Id))
						.AsGuid()
						.NotNullable()
						.PrimaryKey()
						.Identity()
					.WithColumn(nameof(Animal.SpeciesId))
						.AsGuid()
						.NotNullable()
						.ForeignKey(nameof(Species), nameof(Species.Id))
					.WithColumn(nameof(Animal.Name))
						.AsString(nameColumnLength)
						.NotNullable();


		private void CreatePersonTables(int nameColumnLength)
		{
			CreatePersonTable(nameColumnLength);
		}

		private void CreatePersonTable(int nameColumnLength) =>
			Create
				.Table(nameof(Person))
					.WithColumn(nameof(Person.Id))
						.AsGuid()
						.NotNullable()
						.PrimaryKey()
						.Identity()
					.WithColumn(nameof(Person.Name))
						.AsString(nameColumnLength)
						.NotNullable();


		private void CreateLoginTables(int usernameColumnLength, int securityColumnLength)
		{
			CreateCredentialsTable(securityColumnLength);
			CreateLoginCredentialsTable(usernameColumnLength);
		}

		private void CreateCredentialsTable(int securityColumnLength) =>
			Create
				.Table(nameof(Credentials))
					.WithColumn(nameof(Credentials.Id))
						.AsGuid()
						.NotNullable()
						.PrimaryKey()
						.Identity()
					.WithColumn(nameof(Credentials.Hash))
						.AsFixedLengthAnsiString(securityColumnLength)
						.NotNullable()
					.WithColumn(nameof(Credentials.Salt))
						.AsFixedLengthAnsiString(securityColumnLength)
						.NotNullable();

		private void CreateLoginCredentialsTable(int usernameColumnLength) =>
			Create
				.Table(nameof(LoginCredentials))
					.WithColumn(nameof(LoginCredentials.PersonId))
						.AsGuid()
						.NotNullable()
						.PrimaryKey()
						.Identity()
						.ForeignKey(nameof(Person), nameof(Person.Id))
					.WithColumn(nameof(LoginCredentials.CredentialsId))
						.AsGuid()
						.NotNullable()
						.ForeignKey(nameof(Credentials), nameof(Credentials.Id))
					.WithColumn(nameof(LoginCredentials.Username))
						.AsString()
						.NotNullable();
	

		private void CreateReportTables()
		{
			CreateReportTable();
			CreateEntryTable();
		}

		private void CreateReportTable() =>
			Create
				.Table(nameof(Report))
					.WithColumn(nameof(Report.Id))
						.AsGuid()
						.NotNullable()
						.PrimaryKey()
						.Identity()
					.WithColumn(nameof(Report.Animal))
						.AsGuid()
						.ForeignKey(nameof(Animal), nameof(Animal.Id))
					.WithColumn(nameof(Report.ReporterId))
						.AsGuid()
						.ForeignKey(nameof(Person), nameof(Person.Id));

		private void CreateEntryTable() =>
			Create
				.Table(nameof(Entry))
					.WithColumn(nameof(Entry.Id))
						.AsGuid()
						.NotNullable()
	}
}
