namespace MasGlobal.HandsOnTest.Domain.Interfaces.Base
{
    using MasGlobal.HandsOnTest.Domain.Entities;
    using System.Collections.Generic;

    public interface IReadRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
