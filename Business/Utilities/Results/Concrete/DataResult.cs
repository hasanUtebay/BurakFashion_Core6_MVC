using Business.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Results.Concrete
{
    public abstract class DataResult<T> : Result,IDataResult<T>
    {
        public T Data { get; }
               
        public DataResult(T data,bool success,string message):base(success,message) 
        {
            Data= data;
        }

        public DataResult(T data,bool success):base(success)
        {
            Data= data;
        }
    }
}
