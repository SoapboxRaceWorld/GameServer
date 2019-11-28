using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ChatTranscript", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ChatTranscript
	{
		[DataMember]
		public string Message {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public string TargetPersonaId {get; set;}
		[DataMember]
		public long UserId {get; set;}
	}
}
