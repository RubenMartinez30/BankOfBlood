namespace DomainClass.Common;

public class BaseEntity
{
    //las propiedades almacenan los datos de la entidad
    //las propiedades pueden ser de solo lectura, solo escritura o de lectura y escritura
    public int Id { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
}
