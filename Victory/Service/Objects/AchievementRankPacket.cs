using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementRankPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementRankPacket
	{
		[DataMember]
		public System.DateTime AchievedOn {get; set;}
		[DataMember]
		public System.Int32 AchievementRankId {get; set;}
		[DataMember]
		public System.Boolean IsRare {get; set;}
		[DataMember]
		public System.Int16 Points {get; set;}
		[DataMember]
		public System.Int16 Rank {get; set;}
		[DataMember]
		public System.Single Rarity {get; set;}
		[DataMember]
		public System.String RewardDescription {get; set;}
		[DataMember]
		public System.String RewardType {get; set;}
		[DataMember]
		public System.String RewardVisualStyle {get; set;}
		[DataMember]
		public Victory.Service.Objects.AchievementState State {get; set;}
		[DataMember]
		public System.Int64 ThresholdValue {get; set;}
	}
}
