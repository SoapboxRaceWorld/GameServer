using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementsAwarded", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementsAwarded
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.AchievementAwarded> Achievements {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.BadgePacket> Badges {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.AchievementProgress> Progressed {get; set;}
		[DataMember]
		public int Score {get; set;}
	}
}
