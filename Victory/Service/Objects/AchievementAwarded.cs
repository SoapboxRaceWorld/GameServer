using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementAwarded", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementAwarded
	{
		[DataMember]
		public System.DateTime AchievedOn {get; set;}
		[DataMember]
		public System.Int32 AchievementDefinitionId {get; set;}
		[DataMember]
		public System.Int32 AchievementRankId {get; set;}
		[DataMember]
		public System.String Clip {get; set;}
		[DataMember]
		public System.Single ClipLengthInSeconds {get; set;}
		[DataMember]
		public System.String Description {get; set;}
		[DataMember]
		public System.String Icon {get; set;}
		[DataMember]
		public System.Boolean IsRare {get; set;}
		[DataMember]
		public System.String Name {get; set;}
		[DataMember]
		public System.Int16 Points {get; set;}
		[DataMember]
		public System.Single Rarity {get; set;}
	}
}
