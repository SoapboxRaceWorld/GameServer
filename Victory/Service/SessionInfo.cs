using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "SessionInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class SessionInfo
	{
		[DataMember]
		public Victory.Service.SecurityChallenge Challenge {get; set;}
		[DataMember]
		public int EventId {get; set;}
		[DataMember]
		public long SessionId {get; set;}
	}
}
