using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "SecurityChallenge", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class SecurityChallenge
	{
		[DataMember]
		public System.String ChallengeId {get; set;}
		[DataMember]
		public System.Int32 LeftSize {get; set;}
		[DataMember]
		public System.String Pattern {get; set;}
		[DataMember]
		public System.Int32 RightSize {get; set;}
	}
}
