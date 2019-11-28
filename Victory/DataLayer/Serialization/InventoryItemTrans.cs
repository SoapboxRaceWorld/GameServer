using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InventoryItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InventoryItemTrans
	{
		[DataMember]
		public string EntitlementTag {get; set;}
		[DataMember]
		public System.DateTime ExpirationDate {get; set;}
		[DataMember]
		public int Hash {get; set;}
		[DataMember]
		public long InventoryId {get; set;}
		[DataMember]
		public string ProductId {get; set;}
		[DataMember]
		public long RemainingUseCount {get; set;}
		[DataMember]
		public double ResellPrice {get; set;}
		[DataMember]
		public string Status {get; set;}
		[DataMember]
		public string StringHash {get; set;}
		[DataMember]
		public string VirtualItemType {get; set;}
	}
}
