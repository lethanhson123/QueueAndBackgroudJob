namespace Data.Repositories.TestDB
{
	public class CustomerRepository : Repository<Data.Databases.TestDB.Customer>, ICustomerRepository
	{
		private readonly TestDbContext _context;
		public CustomerRepository(TestDbContext context) : base(context)
		{
			_context = context;
		}
	}
}

