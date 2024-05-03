﻿using Travela.BusinessLayer.Results.Abstract;

namespace Travela.BusinessLayer.Results.Concrete
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }
        public Result(bool success,string  message):this(success)
        {
            Message = message;
                
        }
        public Result(bool success)
        {
            Success = success;       
        }
    }
}
