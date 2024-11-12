using Caramel.Website.Partners.Models.Enums;
using System.Net;
using System.Text.Json.Serialization;

namespace Caramel.Website.Partners.Models.Exceptions
{
    public class BusinessException
    {
        public StatusProcess Status { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string[] ErrorDetails { get; set; }

        [JsonConstructor]
        public BusinessException(StatusProcess status, HttpStatusCode statusCode, string[] errorDetails)
        {
            Status = status;
            StatusCode = statusCode;
            ErrorDetails = errorDetails;
        }

        public BusinessException(StatusProcess status, HttpStatusCode statusCode, string errorDetails)
        {
            Status = status;
            StatusCode = statusCode;
            ErrorDetails = new[] { errorDetails };
        }

        public BusinessException() { }
    }
}
