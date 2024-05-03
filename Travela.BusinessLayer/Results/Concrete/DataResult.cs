using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.BusinessLayer.Results.Abstract;

namespace Travela.BusinessLayer.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }
        public DataResult(T data,bool success,string message):base(success, message)
        {
            Data = data;
        }
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
  
    }
}
