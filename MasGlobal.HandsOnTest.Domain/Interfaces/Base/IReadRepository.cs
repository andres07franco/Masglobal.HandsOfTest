namespace MasGlobal.HandOnTest.Domain.Interfaces.Base
{
    using MasGlobal.HandOnTest.Domain.Entities;
    using System.Collections.Generic;

    public interface IReadRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
