

namespace Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
		public virtual DbSet<T> DbSet()
		{
			return _context.Set<T>();
		}
		public virtual void Initialization(T model)
        {
        }
        public virtual int Add(T model)
        {
            int result = 0;
            try
            {
                Initialization(model);
                _context.Set<T>().Add(model);
                result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<int> AddAsync(T model)
        {
            int result = 0;
            try
            {
                Initialization(model);
                _context.Set<T>().Add(model);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual int Update(T model)
        {
            int result = 0;
            try
            {
                Initialization(model);
                _context.Set<T>().Update(model);
                result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<int> UpdateAsync(T model)
        {
            int result = 0;
            try
            {
                Initialization(model);
                _context.Set<T>().Update(model);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual int Remove(T model)
        {
            int result = 0;
            try
            {
                _context.Set<T>().Remove(model);
                result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<int> RemoveAsync(T model)
        {
            int result = 0;
            try
            {
                _context.Set<T>().Remove(model);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual int AddRange(List<T> list)
        {
            int result = 0;
            if (list.Count > 0)
            {
                _context.Set<T>().AddRange(list);
                result = _context.SaveChanges();
            }
            return result;
        }
        public virtual async Task<int> AddRangeAsync(List<T> list)
        {
            int result = 0;
            if (list.Count > 0)
            {
                _context.Set<T>().AddRange(list);
                result = await _context.SaveChangesAsync();
            }
            return result;
        }
        public virtual int UpdateRange(List<T> list)
        {
            int result = 0;
            if (list.Count > 0)
            {
                _context.Set<T>().UpdateRange(list);
                result = _context.SaveChanges();
            }
            return result;
        }
        public virtual async Task<int> UpdateRangeAsync(List<T> list)
        {
            int result = 0;
            if (list.Count > 0)
            {
                _context.Set<T>().UpdateRange(list);
                result = await _context.SaveChangesAsync();
            }
            return result;
        }
        public virtual int RemoveRange(List<T> list)
        {
            int result = 0;
            if (list.Count > 0)
            {
                _context.Set<T>().RemoveRange(list);
                result = _context.SaveChanges();
            }
            return result;
        }
        public virtual async Task<int> RemoveRangeAsync(List<T> list)
        {
            int result = 0;
            if (list.Count > 0)
            {
                _context.Set<T>().RemoveRange(list);
                result = await _context.SaveChangesAsync();
            }
            return result;
        }
        public virtual IEnumerable<T> ExecuteSQLToIEnumerable(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = SQLHelper.FillDataTableBySQL(_context.Database.GetDbConnection().ConnectionString, sql, parameters);
            var result = dt.ToIEnumerable<T>();
            return result;
        }
        public virtual List<T> ExecuteSQLToList(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = SQLHelper.FillDataTableBySQL(_context.Database.GetDbConnection().ConnectionString, sql, parameters);
            var result = dt.ToList<T>();
            return result;
        }		
		public virtual List<T> GetAllToList()
        {
            var result = _context.Set<T>().ToList();
            return result ?? new List<T>();
        }		
		public virtual IQueryable<T> GetAllToIQueryable()
        {
            var result = _context.Set<T>().AsQueryable();
            return result;
        }
        public virtual IEnumerable<T> GetAllToIEnumerable()
        {
            var result = _context.Set<T>().AsEnumerable();
            return result;
        }		
		public virtual async Task<List<T>> GetAllToListAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result ?? new List<T>();
        }
        public virtual List<T> GetByPageAndPageSizeToList(int page, int pageSize)
        {
            var result = _context.Set<T>().Skip(page * pageSize).Take(pageSize).ToList();
            return result;
        }
        public virtual IQueryable<T> GetByPageAndPageSizeToIQueryable(int page, int pageSize)
        {
            var result = _context.Set<T>().Skip(page * pageSize).Take(pageSize).AsQueryable();
            return result;
        }
        public virtual IEnumerable<T> GetByPageAndPageSizeToIEnumerable(int page, int pageSize)
        {
            var result = _context.Set<T>().Skip(page * pageSize).Take(pageSize).AsEnumerable();
            return result;
        }
        public virtual async Task<List<T>> GetByPageAndPageSizeToListAsync(int page, int pageSize)
        {
            var result = await _context.Set<T>().Skip(page * pageSize).Take(pageSize).ToListAsync();
            return result;
        }		
	}
}
