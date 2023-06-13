namespace Data.Repositories.TPFServices
{
	public class AppClientRepository : Repository<Data.Databases.TPFServices.AppClient>, IAppClientRepository
	{
		private readonly TpfservicesContext _context;
		public AppClientRepository(TpfservicesContext context) : base(context)
		{
			_context = context;
		}
	}
}

