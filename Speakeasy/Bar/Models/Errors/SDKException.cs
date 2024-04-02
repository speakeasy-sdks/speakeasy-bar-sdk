
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar.Models.Errors
{
    using System;
    using System.Net.Http;

    public class SDKException : Exception
    {
        public int StatusCode { get; set; }

        public override string Message { get; }
        public string Body { get; set; }

        public HttpResponseMessage RawResponse { get; set; } = default!;

        public SDKException(string message, int statusCode, string body, HttpResponseMessage rawResponse)
        {
            Message = message;
            StatusCode = statusCode;
            Body = body;
            RawResponse = rawResponse;
        }

        public override string ToString(){
            var body = "";
            if (Body.Length > 0)
            {
                body += $"\n{Body}";
            }

            return Message + ": Status " + StatusCode + body;
        }

    }
}
