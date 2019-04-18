using System.Data.SqlClient;

namespace Beastbase.Data.Extensions
{
	public static class ConnectionStringToDatabaseSettingsExtension
	{
		public static DatabaseSettings ToDatabaseSettings(this string connectionString)
		{
			var builder = new SqlConnectionStringBuilder(connectionString);

			var server = builder["Server"].ToString();
			var database = builder["Database"].ToString();
			//var port = builder["Port"];
			var username = builder["User Id"].ToString();
			var password = builder["Password"].ToString();

			var settings = new DatabaseSettings
			{
				Server = server,
				Database = database,
				//Port = port,
				UserName = username,
				Password = password,
			};

			return settings;
		}
	}
}
