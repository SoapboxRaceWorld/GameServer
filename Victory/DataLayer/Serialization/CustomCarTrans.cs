using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CustomCarTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CustomCarTrans
	{
		[DataMember]
		public System.Int32 BaseCar {get; set;}
		[DataMember]
		public System.Int32 CarClassHash {get; set;}
		[DataMember]
		public System.Int32 Id {get; set;}
		[DataMember]
		public System.Boolean IsPreset {get; set;}
		[DataMember]
		public System.Int32 Level {get; set;}
		[DataMember]
		public System.String Name {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.CustomPaintTrans> Paints {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.PerformancePartTrans> PerformanceParts {get; set;}
		[DataMember]
		public System.Int32 PhysicsProfileHash {get; set;}
		[DataMember]
		public System.Int32 Rating {get; set;}
		[DataMember]
		public System.Single ResalePrice {get; set;}
		[DataMember]
		public System.Single RideHeightDrop {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.SkillModPartTrans> SkillModParts {get; set;}
		[DataMember]
		public System.Int32 SkillModSlotCount {get; set;}
		[DataMember]
		public System.Int32 Version {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.CustomVinylTrans> Vinyls {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.VisualPartTrans> VisualParts {get; set;}
	}
}
