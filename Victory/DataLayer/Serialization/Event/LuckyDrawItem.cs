using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "LuckyDrawItem", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class LuckyDrawItem
	{
		[DataMember]
		public System.String Description {get; set;}
		[DataMember]
		public System.Int32 Hash {get; set;}
		[DataMember]
		public System.String Icon {get; set;}
		[DataMember]
		public System.Int32 RemainingUseCount {get; set;}
		[DataMember]
		public System.Single ResellPrice {get; set;}
		[DataMember]
		public System.String VirtualItem {get; set;}
		[DataMember]
		public System.String VirtualItemType {get; set;}
		[DataMember]
		public System.Boolean WasSold {get; set;}
	}
}
