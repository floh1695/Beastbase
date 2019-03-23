using System.Data.SqlClient;

namespace Beastbase.Data.ConnectionSettings.Extensions
{
	public static class ConnectionSettingsToConnectionStringExtension
	{
		public static string ToConnectionString(this ConnectionSettings settings)
		{
			var builder = new SqlConnectionStringBuilder();

			builder["Server"] = settings.Server;
			builder["Database"] = settings.Database;

			//if (settings.Port.HasValue)
			//{
			//	builder["Port"] = settings.Port;
			//}

			builder["User Id"] = settings.UserName;
			builder["Password"] = settings.Password;

			return builder.ConnectionString;
		}
	}
}
