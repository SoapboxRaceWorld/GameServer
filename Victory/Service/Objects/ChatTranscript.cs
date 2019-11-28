using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ChatTranscript", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ChatTranscript
	{
		[DataMember]
		public System.String Message {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.String TargetPersonaId {get; set;}
		[DataMember]
		public System.Int64 UserId {get; set;}
	}
}
