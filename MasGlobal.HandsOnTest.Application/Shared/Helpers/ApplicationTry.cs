using MasGlobal.HandsOnTest.Application.Shared.Dtos;
using MasGlobal.HandsOnTest.Domain.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.HandsOnTest.Application.Shared.Helpers
{
    public static class ApplicationTry
    {
        /// <summary>
        /// Tries the specified action.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public static Response<T> Try<T>(Func<T> action)
        {
            var response = new Response<T>();
            try
            {
                response.Entity = action();
                response.IsSuccess = true;
            }
            catch (DomainException be)
            {
            ///    Core.Logger.Current.Error(be.Message);
                response.ErrorMessage = be.Message;
               // response.ErrorCode = be.Tipo;
            }
            catch (Exception ex)
            {
                ///Core.Logger.Current.Error(ex.Message);
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}
