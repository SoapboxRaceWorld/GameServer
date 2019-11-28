using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ClientPhysicsMetrics", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ClientPhysicsMetrics
	{
		[DataMember]
		public float AccelerationAverage {get; set;}
		[DataMember]
		public float AccelerationMaximum {get; set;}
		[DataMember]
		public float AccelerationMedian {get; set;}
		[DataMember]
		public float SpeedAverage {get; set;}
		[DataMember]
		public float SpeedMaximum {get; set;}
		[DataMember]
		public float SpeedMedian {get; set;}
	}
}
