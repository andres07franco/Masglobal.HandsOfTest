namespace MasGlobal.HandsOnTest.Domain.Interfaces.Contract
{
    using MasGlobal.HandOnTest.Domain.Interfaces.Contract;
    using MasGlobal.HandOnTest.Domain.Shared.Enums;

    public interface IContractFactoryMethod
    {
        IContract CreateContract(ContractTypeEnum contractType);
    }
}
