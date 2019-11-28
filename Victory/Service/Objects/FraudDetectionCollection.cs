using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "FraudDetectionCollection", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class FraudDetectionCollection
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.FraudDetection> FraudDetectionLogs {get; set;}
	}
}
