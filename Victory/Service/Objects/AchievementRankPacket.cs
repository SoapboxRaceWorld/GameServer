using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementRankPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementRankPacket
	{
		[DataMember]
		public System.DateTime AchievedOn {get; set;}
		[DataMember]
		public int AchievementRankId {get; set;}
		[DataMember]
		public bool IsRare {get; set;}
		[DataMember]
		public short Points {get; set;}
		[DataMember]
		public short Rank {get; set;}
		[DataMember]
		public float Rarity {get; set;}
		[DataMember]
		public string RewardDescription {get; set;}
		[DataMember]
		public string RewardType {get; set;}
		[DataMember]
		public string RewardVisualStyle {get; set;}
		[DataMember]
		public Victory.Service.Objects.AchievementState State {get; set;}
		[DataMember]
		public long ThresholdValue {get; set;}
	}
}
