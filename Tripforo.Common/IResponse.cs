using System.Net;

namespace Tripforo.Common
{
    public interface IResponse
    {
        bool DidError { get; set; }

        string Messages { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}
