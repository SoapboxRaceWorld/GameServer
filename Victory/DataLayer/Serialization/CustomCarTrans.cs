using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CustomCarTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CustomCarTrans
	{
		[DataMember]
		public int BaseCar {get; set;}
		[DataMember]
		public int CarClassHash {get; set;}
		[DataMember]
		public int Id {get; set;}
		[DataMember]
		public bool IsPreset {get; set;}
		[DataMember]
		public int Level {get; set;}
		[DataMember]
		public string Name {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.CustomPaintTrans> Paints {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.PerformancePartTrans> PerformanceParts {get; set;}
		[DataMember]
		public int PhysicsProfileHash {get; set;}
		[DataMember]
		public int Rating {get; set;}
		[DataMember]
		public float ResalePrice {get; set;}
		[DataMember]
		public float RideHeightDrop {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.SkillModPartTrans> SkillModParts {get; set;}
		[DataMember]
		public int SkillModSlotCount {get; set;}
		[DataMember]
		public int Version {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.CustomVinylTrans> Vinyls {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.VisualPartTrans> VisualParts {get; set;}
	}
}
