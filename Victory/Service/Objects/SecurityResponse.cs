using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "SecurityResponse", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class SecurityResponse
	{
		[DataMember]
		public System.String ChallengeId {get; set;}
		[DataMember]
		public System.Int64 Result {get; set;}
	}
}
