using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace myApp.Core.Dtos
{
    public class CustomResponseDto<T> 
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public ICollection<T> Errors { get; set; }


        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode
            };
        }
        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode,
                Data = data
            };
        }

        public static CustomResponseDto<T> Fail(int statusCode)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode
            };
        }
        public static CustomResponseDto<T> Fail(int statusCode, ICollection<T> errors)
        {
            return new CustomResponseDto<T>
            {
                StatusCode = statusCode,
                Errors = errors.ToList()
            };
        }
    }
}
