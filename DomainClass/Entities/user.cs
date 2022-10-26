using DomainClass.Common;

namespace DomainClass.Entities;

public class user : BaseEntity
{
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string dni { get; set; }
    public DateTime birthDay { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public int idLocation { get; set; }
    public int IdBloodType { get; set; }

}
