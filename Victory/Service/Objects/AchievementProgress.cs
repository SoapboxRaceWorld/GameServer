using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementProgress", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementProgress
	{
		[DataMember]
		public System.Int32 AchievementDefinitionId {get; set;}
		[DataMember]
		public System.Int64 CurrentValue {get; set;}
	}
}
