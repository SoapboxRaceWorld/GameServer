using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "RouteEntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class RouteEntrantResult
	{
		[DataMember]
		public System.UInt32 BestLapDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Single TopSpeed {get; set;}
	}
}
