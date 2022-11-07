using System.Net;
using FirebaseCSharp.Extensions;

namespace FirebaseCSharp.Response
{
    public class FirebaseResponse
    {
        public FirebaseResponse(string body, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Body = body;
        }

        public string Body { get; }

        public HttpStatusCode StatusCode { get; }

        public virtual T ResultAs<T>()
        {
            return Body.ReadAs<T>();
        }
    }
}
