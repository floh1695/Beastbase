namespace Beastbase.Entities
{
	public class Entry
	{
		public int Id { get; set; }

		public int ReportId { get; set; }
		public virtual Report Report { get; set; }

		public int ReporterId { get; set; }
		public virtual Person Reporter { get; set; }
	}
}
