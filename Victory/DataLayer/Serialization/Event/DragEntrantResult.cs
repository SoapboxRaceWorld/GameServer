using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "DragEntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class DragEntrantResult
	{
		[DataMember]
		public float TopSpeed {get; set;}
	}
}
