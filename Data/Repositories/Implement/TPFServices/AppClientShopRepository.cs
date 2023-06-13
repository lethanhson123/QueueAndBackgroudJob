namespace Data.Repositories.TPFServices
{
	public class AppClientShopRepository : Repository<Data.Databases.TPFServices.AppClientShop>, IAppClientShopRepository
	{
		private readonly TpfservicesContext _context;
		public AppClientShopRepository(TpfservicesContext context) : base(context)
		{
			_context = context;
		}
	}
}

