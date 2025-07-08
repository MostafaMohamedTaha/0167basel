using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace basel.core.Repo
{
    public class Res<T>
    {
        #region props
        public HttpStatusCode StatusCode { get; set; }
        public T? Data { get; set; }
        public bool IsSuccess { get; set; } = false;
        public object? Meta { get; set; }
        public string Message { get; set; } = string.Empty;
        #endregion

        #region ctor
        public Res(T data, string message)
        {
            IsSuccess = true;
            Data = data;
            Message = message;
        }

        public Res(string message)
        {
            IsSuccess = false;
            Meta = false;
            Message = message;
        }

        public Res(string message, bool succeed)
        {
            IsSuccess = succeed;
            Message = message;
        }

        public Res()
        {
        }
        #endregion

    }
}
