using System.Net;

namespace FirebaseCSharp.Response
{
    public class SetResponse : FirebaseResponse
    {
        public SetResponse(string body, HttpStatusCode statusCode)
            : base(body, statusCode)
        {
        }
    }
}
