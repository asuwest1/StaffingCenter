using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.Helpers
{
    public class ResultHelperBase
    {
        private bool _success;

        public ResultHelperBase()
        {
            Success = false;
            Message = "";
            Code = -1;
        }
        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }
        public string Message { get; set; }
        public int Code { get; set; }
        public bool HasError { get; set; }
        protected void PrepareResult(bool response, string message = "", int code = 0)
        {
            //if code = 0 se tome 200 o 500
            //tambien podemos hacer una lista de errores con un enumerable para llenar mas rapido los errores
            //tambien puedes dejar una opcion para solo mandar el exception y formar el mensae aqui
            Success = response;
            Code = code;
            if (response)
            {
                Message = (string.IsNullOrEmpty(message) ? "Success" : message);
            }
            else
            {
                HasError = true;
                Message = (string.IsNullOrEmpty(message) ? "Failure" : message);
            }
        }
    }
    public class ResultHelper : ResultHelperBase
    {
        public static ResultHelper Init { get { return new ResultHelper(); } }
        public ResultHelper SetSucces()
        {
            PrepareResult(true);
            return this;
        }
        public ResultHelper SetSucces(object value)
        {
            PrepareResult(true);
            return this;
        }
        public ResultHelper SetSucces(string message)
        {
            PrepareResult(true, message);
            return this;
        }
        public ResultHelper SetSucces(string message, int code)
        {
            PrepareResult(true, message, code);
            return this;
        }
        public ResultHelper SetError(string message)
        {
            PrepareResult(false, message);
            return this;
        }
        public ResultHelper SetError(string message, int code)
        {
            PrepareResult(false, message, code);
            return this;
        }
    }
    public class ResultHelper<T> : ResultHelperBase where T : class
    {
        public static ResultHelper<T> Init { get { return new ResultHelper<T>(); } }
        public T DataResult { get; set; }
        public ResultHelper<T> SetSucces(T dataResult)
        {
            DataResult = dataResult;
            PrepareResult(true);
            return this;
        }
        public ResultHelper<T> SetSucces(T dataResult, string message)
        {
            DataResult = dataResult;
            PrepareResult(true, message);
            return this;
        }
        public ResultHelper<T> SetSucces(T dataResult,string message, int code)
        {
            DataResult = dataResult;
            PrepareResult(true, message, code);
            return this;
        }
        public ResultHelper<T> SetError(int code)
        {
            PrepareResult(false, code:code);
            return this;
        }
        public ResultHelper<T> SetError(string message)
        {
            PrepareResult(false, message);
            return this;
        }
        public ResultHelper<T> SetError(T dataResult, string message, int code)
        {
            DataResult = dataResult;
            PrepareResult(false, message, code);
            return this;
        }
        public ResultHelper<T> SetError(string message, int code)
        {
            PrepareResult(false, message, code);
            return this;
        }
    }
}