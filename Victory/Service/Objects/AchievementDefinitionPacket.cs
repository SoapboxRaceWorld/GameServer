using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementDefinitionPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementDefinitionPacket
	{
		[DataMember]
		public System.Int32 AchievementDefinitionId {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.AchievementRankPacket> AchievementRanks {get; set;}
		[DataMember]
		public System.Int32 BadgeDefinitionId {get; set;}
		[DataMember]
		public System.Boolean CanProgress {get; set;}
		[DataMember]
		public System.Int64 CurrentValue {get; set;}
		[DataMember]
		public System.Boolean IsVisible {get; set;}
		[DataMember]
		public System.String ProgressText {get; set;}
		[DataMember]
		public Victory.Service.Objects.StatConversion StatConversion {get; set;}
	}
}
