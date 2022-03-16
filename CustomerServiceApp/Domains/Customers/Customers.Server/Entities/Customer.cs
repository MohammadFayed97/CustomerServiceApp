namespace Customers.Server.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
}
