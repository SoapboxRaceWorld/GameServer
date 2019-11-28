using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "RouteEntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class RouteEntrantResult
	{
		[DataMember]
		public uint BestLapDurationInMilliseconds {get; set;}
		[DataMember]
		public float TopSpeed {get; set;}
	}
}
