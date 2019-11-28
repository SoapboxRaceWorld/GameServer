using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgePacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgePacket
	{
		[DataMember]
		public System.Int32 AchievementRankId {get; set;}
		[DataMember]
		public System.Int32 BadgeDefinitionId {get; set;}
		[DataMember]
		public System.Boolean IsRare {get; set;}
		[DataMember]
		public System.Single Rarity {get; set;}
		[DataMember]
		public System.Int16 SlotId {get; set;}
	}
}
