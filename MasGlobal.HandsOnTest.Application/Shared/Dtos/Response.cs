namespace MasGlobal.HandsOnTest.Application.Shared.Dtos
{

    using System;

    public class Response<TEntity>
    {
        public TEntity Entity { get; set; }
        public bool IsSuccess { set; get; }
        public string ErrorMessage {get;set;}
        public int ErrorCode { get; set; }
      //  public Exception Exception { get; set; }
    }
}
