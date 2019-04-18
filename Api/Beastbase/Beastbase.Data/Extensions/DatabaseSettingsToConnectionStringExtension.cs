using System.Data.SqlClient;

namespace Beastbase.Data.Extensions
{
	public static class DatabaseSettingsToConnectionStringExtension
	{
		public static string ToConnectionString(this DatabaseSettings settings)
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
