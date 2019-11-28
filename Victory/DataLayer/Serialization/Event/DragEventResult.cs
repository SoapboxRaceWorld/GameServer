using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "DragEventResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class DragEventResult
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.DragEntrantResult> Entrants {get; set;}
	}
}
