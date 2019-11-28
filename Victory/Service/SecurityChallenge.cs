using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "SecurityChallenge", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class SecurityChallenge
	{
		[DataMember]
		public string ChallengeId {get; set;}
		[DataMember]
		public int LeftSize {get; set;}
		[DataMember]
		public string Pattern {get; set;}
		[DataMember]
		public int RightSize {get; set;}
	}
}
