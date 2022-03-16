namespace AppSquare.Shared.Server;

public class BaseGetRepository<TEntity> : IBaseGetRepository<TEntity> 
    where TEntity : BaseEntity
{
    protected DbSet<TEntity> _table;

    public BaseGetRepository(ApplicationContext context)
    {
        Context = context;
        _table = context.Set<TEntity>();
    }

    public ApplicationContext Context { get; }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _table.ToListAsync();
    public virtual async Task<IEnumerable<TEntity>> GetByExprissionAsync(Expression<Func<TEntity, bool>> expression)
        => await _table.Where(expression).ToListAsync();
    public virtual async Task<TEntity> GetByIdAsync(Guid id) => await _table.FirstOrDefaultAsync(e => e.Id == id);
}
