using AutoMapper;
using MasGlobal.HandsOnTest.Api.Helpers.AutoMapper;
using MasGlobal.HandsOnTest.Application.Shared.Dtos;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MasGlobal.HandsOnTest.Api.Helpers
{
    public class UseCaseRunner
    {
        private readonly Mapper mapper;

        private UseCaseRunner()
        {
            var config = MapperConfigurationBuilder.Build();
            this.mapper = new Mapper(config);
        }

        public static UseCaseRunner Instance { get; } = new UseCaseRunner();


        /// <summary>
        /// Tries the specified action.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public TViewModel ProcessResponse<TViewModel, TEntity>(Response<TEntity> response)
        {
        
            if(!response.IsSuccess)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(response.ErrorMessage),
                    ReasonPhrase = "Error Code " + response.ErrorCode.ToString()
                };
                throw new HttpResponseException(resp);
            }

            return this.mapper.Map<TViewModel>(response.Entity);
                   
        }

        /// <summary>
        /// Tries the specified action.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public IEnumerable<TViewModel> ProcessResponse<TViewModel, TEntity>(Response<IEnumerable<TEntity>> response)
        {

            if (!response.IsSuccess)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(response.ErrorMessage),
                    ReasonPhrase = "Error Code " + response.ErrorCode.ToString()
                };
                throw new HttpResponseException(resp);
            }


            return this.mapper.Map<IEnumerable<TViewModel>>(response.Entity);

        }
    }
}