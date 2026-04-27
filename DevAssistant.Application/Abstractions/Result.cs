using System;
using System.Collections.Generic;
using System.Text;

namespace DevAssistant.Application.Abstractions
{
    public class Result
    {
        public Result(bool issuccess,Error _error) 
        {
             if((issuccess&&error!=Error.None) || (!issuccess && error == Error.None))
            {
                throw new InvalidOperationException();
            }


            ISsuccess=issuccess;
            error = _error;
        }
        public bool ISsuccess {  get;}
        public bool IFailure => !ISsuccess;
        public Error error { get; } = default!;

        public static Result Success()=>new(true,Error.None);
        public static Result Failure(Error error)=>new(false,error);
        public static Result<Tvalue> Success<Tvalue>(Tvalue value)=>new(value,true, Error.None);
        public static Result<Tvalue> Failure<Tvalue>(Tvalue value, Error error)=>new(value, false,error);

    }


    public class Result<Tvalue> : Result
    {
        private readonly Tvalue? _value;

        public Result(Tvalue value,bool issuccess, Error _error) : base(issuccess, _error)
        {
            _value=value;
        }
    }
}
