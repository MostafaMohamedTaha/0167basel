using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.core.Repo
{
    public class ResHandler
    {
        public Res<T> Deleted<T>()
        {
            return new Res<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                IsSuccess = true,
                Message = "deleted succeed"
            };
        }
        public Res<T> Success<T>(T data,object? meta =null)
        {
            return new Res<T>()
            {
                Data = data,
                StatusCode = System.Net.HttpStatusCode.OK,
                IsSuccess = true,
                Message = "add succeed",
                Meta = meta
            };
        }
        public Res<T> Created<T>(T data,object meta)
        {
            return new Res<T>()
            {
                Data = data,
                StatusCode = System.Net.HttpStatusCode.Created,
                IsSuccess = true,
                Message = "create succeed",
                Meta= meta
            };
        }
        public Res<T> NotFound<T>(string message)
        {
            return new Res<T>()
            {
                
                StatusCode = System.Net.HttpStatusCode.NotFound,
                IsSuccess = false,
                Message = message
                
            };
        }
        public Res<T> Unauthorized<T>(string message)
        {
            return new Res<T>()
            {
                
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                IsSuccess = false,
                Message = message
                
            };
        }
        public Res<T> BadRequest<T>(string message)
        {
            return new Res<T>()
            {
                
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                IsSuccess = false,
                Message = message
                
            };
        }
    }
}
