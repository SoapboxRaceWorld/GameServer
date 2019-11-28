using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "PursuitEventResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class PursuitEventResult
	{
		[DataMember]
		public System.Single Heat {get; set;}
	}
}
