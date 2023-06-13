
namespace Data.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        public DbSet<T> DbSet();
		public int Add(T model);
        public Task<int> AddAsync(T model);
        public int Update(T model);
        public Task<int> UpdateAsync(T model);
        public int Remove(T model);
        public Task<int> RemoveAsync(T model);
        public int AddRange(List<T> list);
        public Task<int> AddRangeAsync(List<T> list);
        public int UpdateRange(List<T> list);
        public Task<int> UpdateRangeAsync(List<T> list);
        public int RemoveRange(List<T> list);
        public Task<int> RemoveRangeAsync(List<T> list);
        public IEnumerable<T> ExecuteSQLToIEnumerable(string sql, params SqlParameter[] parameters);
        public List<T> ExecuteSQLToList(string sql, params SqlParameter[] parameters);
        public List<T> GetAllToList();
        public Task<List<T>> GetAllToListAsync();
        public IQueryable<T> GetAllToIQueryable();
        public IEnumerable<T> GetAllToIEnumerable();
        public List<T> GetByPageAndPageSizeToList(int page, int pageSize);
        public IQueryable<T> GetByPageAndPageSizeToIQueryable(int page, int pageSize);
        public IEnumerable<T> GetByPageAndPageSizeToIEnumerable(int page, int pageSize);
		public Task<List<T>> GetByPageAndPageSizeToListAsync(int page, int pageSize);
    }
}
