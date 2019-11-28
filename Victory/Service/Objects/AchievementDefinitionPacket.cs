using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementDefinitionPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementDefinitionPacket
	{
		[DataMember]
		public int AchievementDefinitionId {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.AchievementRankPacket> AchievementRanks {get; set;}
		[DataMember]
		public int BadgeDefinitionId {get; set;}
		[DataMember]
		public bool CanProgress {get; set;}
		[DataMember]
		public long CurrentValue {get; set;}
		[DataMember]
		public bool IsVisible {get; set;}
		[DataMember]
		public string ProgressText {get; set;}
		[DataMember]
		public Victory.Service.Objects.StatConversion StatConversion {get; set;}
	}
}
