using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "ServerTime", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class ServerTime
	{
		[DataMember]
		public System.DateTime Current {get; set;}
	}
}
