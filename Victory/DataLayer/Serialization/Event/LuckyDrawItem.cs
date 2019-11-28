using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "LuckyDrawItem", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class LuckyDrawItem
	{
		[DataMember]
		public string Description {get; set;}
		[DataMember]
		public int Hash {get; set;}
		[DataMember]
		public string Icon {get; set;}
		[DataMember]
		public int RemainingUseCount {get; set;}
		[DataMember]
		public float ResellPrice {get; set;}
		[DataMember]
		public string VirtualItem {get; set;}
		[DataMember]
		public string VirtualItemType {get; set;}
		[DataMember]
		public bool WasSold {get; set;}
	}
}
