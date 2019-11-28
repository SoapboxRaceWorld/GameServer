using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ClientPhysicsMetrics", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ClientPhysicsMetrics
	{
		[DataMember]
		public System.Single AccelerationAverage {get; set;}
		[DataMember]
		public System.Single AccelerationMaximum {get; set;}
		[DataMember]
		public System.Single AccelerationMedian {get; set;}
		[DataMember]
		public System.Single SpeedAverage {get; set;}
		[DataMember]
		public System.Single SpeedMaximum {get; set;}
		[DataMember]
		public System.Single SpeedMedian {get; set;}
	}
}
