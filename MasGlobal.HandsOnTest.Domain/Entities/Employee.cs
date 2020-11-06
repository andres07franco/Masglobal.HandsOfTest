namespace MasGlobal.HandOnTest.Domain.Entities
{
    using MasGlobal.HandOnTest.Domain.Shared.Enums;

    public class Employee: BaseEntity
    {
        public double Salary { get; set; }
        public double AnualSalary { get; set; }
        public ContractTypeEnum ContractType { get; set; }
        public Role Role { get;  set; }
    }
}
