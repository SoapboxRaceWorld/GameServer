using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementProgress", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementProgress
	{
		[DataMember]
		public int AchievementDefinitionId {get; set;}
		[DataMember]
		public long CurrentValue {get; set;}
	}
}
