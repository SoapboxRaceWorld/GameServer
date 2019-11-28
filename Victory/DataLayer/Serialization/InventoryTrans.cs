using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InventoryTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InventoryTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.InventoryItemTrans> InventoryItems {get; set;}
		[DataMember]
		public long PerformancePartsCapacity {get; set;}
		[DataMember]
		public long PerformancePartsUsedSlotCount {get; set;}
		[DataMember]
		public long SkillModPartsCapacity {get; set;}
		[DataMember]
		public long SkillModPartsUsedSlotCount {get; set;}
		[DataMember]
		public long VisualPartsCapacity {get; set;}
		[DataMember]
		public long VisualPartsUsedSlotCount {get; set;}
	}
}
