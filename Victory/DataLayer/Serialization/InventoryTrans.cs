using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InventoryTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InventoryTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.InventoryItemTrans> InventoryItems {get; set;}
		[DataMember]
		public System.Int64 PerformancePartsCapacity {get; set;}
		[DataMember]
		public System.Int64 PerformancePartsUsedSlotCount {get; set;}
		[DataMember]
		public System.Int64 SkillModPartsCapacity {get; set;}
		[DataMember]
		public System.Int64 SkillModPartsUsedSlotCount {get; set;}
		[DataMember]
		public System.Int64 VisualPartsCapacity {get; set;}
		[DataMember]
		public System.Int64 VisualPartsUsedSlotCount {get; set;}
	}
}
