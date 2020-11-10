namespace MasGlobal.HandsOnTest.Domain.Interfaces.Contract
{
    using MasGlobal.HandsOnTest.Domain.Shared.Enums;

    public interface IContractFactoryMethod
    {
        IContractCalculator CreateContract(ContractTypeEnum contractType);
    }
}
