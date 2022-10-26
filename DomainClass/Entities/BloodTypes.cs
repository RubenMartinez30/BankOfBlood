using DomainClass.Common;

namespace DomainClass.Entities;

public class BloodTypes : BaseEntity
{
    public string BloodGroup { get; set; }  // A - B - AB - O
    public bool Rh { get; set; }  // 1 para positivo, 0 para negativo
}
