
namespace MasGlobal.HandsOnTest.Domain.Entities
{
    using MasGlobal.HandsOnTest.Domain.Shared.Enums;

    public class Contract 
    {
        public double Salary { get; set; }
        public double AnnualSalary { get; set; }
        public ContractTypeEnum ContractType { get; set; }

    }
}
