using DomainClass.Common;

namespace DomainClass.Entities;

public class Location : BaseEntity
{
    public int IdProvince { get; set; }
    public String Name { get; set; }
    public String cp { get; set; }

}
