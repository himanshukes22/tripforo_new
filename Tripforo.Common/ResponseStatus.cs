using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Tripforo.Common
{
    #region Status Object Class
    /// <summary>
    /// Public class to return input status
    /// </summary>
    [Serializable]
    [DataContract(Name = "Response")]
    public class ResponseStatus<T> : IResponse
    {
        #region Public properties.
        /// <summary>
        /// Get/Set property for accessing Status Code
        /// </summary>
        [JsonProperty("StatusCode")]
        [DataMember(Name = "StatusCode")]
        public HttpStatusCode StatusCode { get; set; }

        [JsonProperty("id")]
        [DataMember(Name = "id")]
        public int ID { get; set; }

        /// <summary>
        /// Get/Set property for accessing Status Message
        /// </summary>
        [JsonProperty("Message")]
        [DataMember(Name = "Message")]
        public string Messages { get; set; }
        /// <summary>
        /// Get/Set property for accessing Status Message
        /// </summary>
        //[JsonProperty("ReasonPhrase")]
        //[DataMember]
        //public string ReasonPhrase { get; set; }

        [JsonProperty("Data")]
        [DataMember(Name = "Data")]
        public T Data { get; set; }

        [JsonProperty("DidError")]
        [DataMember(Name = "DidError")]
        public bool DidError { get; set; }

        #endregion
    }

    #endregion
}
