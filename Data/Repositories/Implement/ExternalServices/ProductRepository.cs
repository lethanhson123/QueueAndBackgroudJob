namespace Data.Repositories.ExternalServices
{
	public class ProductRepository : Repository<Data.Databases.ExternalServices.Product>, IProductRepository
	{
		private readonly ExternalServicesContext _context;
		public ProductRepository(ExternalServicesContext context) : base(context)
		{
			_context = context;
		}
	}
}

