namespace CustomerRequests.Server.Repositories;

public class CustomerRequestRepository : BaseRepository<CustomerRequest>, ICustomerRequestRepository
{
    public CustomerRequestRepository(ApplicationContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<CustomerRequest>> GetAllAsync() => await _table.Include(e => e.Customer).Include(e => e.Service).OrderBy(e => e.DisplayOrder).ToListAsync();
    public override async Task<CustomerRequest> GetByIdAsync(Guid id) 
        => await _table.Where(e => e.Id == id).Include(e => e.Customer).Include(e => e.Service).OrderBy(e => e.DisplayOrder).FirstOrDefaultAsync();
}
