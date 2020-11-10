using System.Collections.Generic;
using System.Web.Http;

namespace MasGlobal.HandsOnTest.Api.Controllers
{
    using MasGlobal.HandsOnTest.Api.Helpers;
    using MasGlobal.HandsOnTest.Application.Shared.Dtos;

    public class BaseApiController<TViewModel, TEntity> : ApiController
    {
        public BaseApiController()
        {

        }

        public IEnumerable<TViewModel> Process(Response<IEnumerable<TEntity>> response)
        {
            return UseCaseRunner.Instance.ProcessResponse<TViewModel, TEntity>(response);
        }

        public TViewModel Process(Response<TEntity> response)
        {
            return UseCaseRunner.Instance.ProcessResponse<TViewModel, TEntity>(response);
        }
    }
}