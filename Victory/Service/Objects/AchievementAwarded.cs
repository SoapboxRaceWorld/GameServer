using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementAwarded", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementAwarded
	{
		[DataMember]
		public System.DateTime AchievedOn {get; set;}
		[DataMember]
		public int AchievementDefinitionId {get; set;}
		[DataMember]
		public int AchievementRankId {get; set;}
		[DataMember]
		public string Clip {get; set;}
		[DataMember]
		public float ClipLengthInSeconds {get; set;}
		[DataMember]
		public string Description {get; set;}
		[DataMember]
		public string Icon {get; set;}
		[DataMember]
		public bool IsRare {get; set;}
		[DataMember]
		public string Name {get; set;}
		[DataMember]
		public short Points {get; set;}
		[DataMember]
		public float Rarity {get; set;}
	}
}
