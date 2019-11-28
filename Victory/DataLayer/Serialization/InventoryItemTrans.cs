using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InventoryItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InventoryItemTrans
	{
		[DataMember]
		public System.String EntitlementTag {get; set;}
		[DataMember]
		public System.DateTime ExpirationDate {get; set;}
		[DataMember]
		public System.Int32 Hash {get; set;}
		[DataMember]
		public System.Int64 InventoryId {get; set;}
		[DataMember]
		public System.String ProductId {get; set;}
		[DataMember]
		public System.Int64 RemainingUseCount {get; set;}
		[DataMember]
		public System.Double ResellPrice {get; set;}
		[DataMember]
		public System.String Status {get; set;}
		[DataMember]
		public System.String StringHash {get; set;}
		[DataMember]
		public System.String VirtualItemType {get; set;}
	}
}
