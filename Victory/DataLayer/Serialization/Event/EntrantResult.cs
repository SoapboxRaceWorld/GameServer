using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EntrantResult
	{
		[DataMember]
		public System.UInt32 EventDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Int64 EventSessionId {get; set;}
		[DataMember]
		public System.Int32 FinishReason {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.Int32 Ranking {get; set;}
	}
}
