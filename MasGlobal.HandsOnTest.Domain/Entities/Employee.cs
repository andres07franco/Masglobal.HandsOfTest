
namespace MasGlobal.HandsOnTest.Domain.Entities
{
    public class Employee: BaseEntity
    {
        public Contract Contract { get; set; }
        public Role Role { get;  set; }
    }
}
