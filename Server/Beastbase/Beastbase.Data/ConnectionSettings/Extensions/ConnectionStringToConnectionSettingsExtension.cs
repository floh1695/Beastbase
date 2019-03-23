using System.Data.SqlClient;

namespace Beastbase.Data.ConnectionSettings.Extensions
{
	public static class ConnectionStringToConnectionSettingsExtension
	{
		public static ConnectionSettings ToConnectionSettings(this string connectionString)
		{
			var builder = new SqlConnectionStringBuilder(connectionString);

			var server = builder["Server"].ToString();
			var database = builder["Database"].ToString();
			//var port = builder["Port"];
			var username = builder["User Id"].ToString();
			var password = builder["Password"].ToString();

			var settings = new ConnectionSettings
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
