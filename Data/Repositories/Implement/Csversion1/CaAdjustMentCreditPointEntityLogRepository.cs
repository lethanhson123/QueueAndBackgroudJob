namespace Data.Repositories.Csversion1
{
	public class CaAdjustMentCreditPointEntityLogRepository : Repository<Data.Databases.Csversion1.CaAdjustMentCreditPointEntityLog>, ICaAdjustMentCreditPointEntityLogRepository
	{
		private readonly Csversion1Context _context;
		public CaAdjustMentCreditPointEntityLogRepository(Csversion1Context context) : base(context)
		{
			_context = context;
		}
	}
}

