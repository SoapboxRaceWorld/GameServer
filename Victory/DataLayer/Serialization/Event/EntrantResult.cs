using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EntrantResult
	{
		[DataMember]
		public uint EventDurationInMilliseconds {get; set;}
		[DataMember]
		public long EventSessionId {get; set;}
		[DataMember]
		public int FinishReason {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public int Ranking {get; set;}
	}
}
