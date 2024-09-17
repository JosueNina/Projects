using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.DTOs.Common
{
    public class ResponseDto<T>
    {
        public bool Sucess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T? Result { get; set; }
    }
}