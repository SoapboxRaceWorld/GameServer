using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementsPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementsPacket
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.BadgeDefinitionPacket> Badges {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.AchievementDefinitionPacket> Definitions {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
	}
}
