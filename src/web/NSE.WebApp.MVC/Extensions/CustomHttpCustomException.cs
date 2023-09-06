using System;
using System.Net;

namespace NSE.WebApp.MVC.Extensions
{
    public class CustomHttpCustomException : Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpCustomException() { }

        public CustomHttpCustomException(string message, Exception innerException) : base(message, innerException) { }

        public CustomHttpCustomException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
