namespace Customers.Server.Repositories;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<Customer>> GetAllAsync() => await _table.Include(e => e.City).ToListAsync();
    public override async Task<Customer> GetByIdAsync(Guid id) => await _table.Where(e => e.Id == id).Include(e => e.City).FirstOrDefaultAsync();
}
