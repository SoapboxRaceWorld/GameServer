using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementRewards", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementRewards
	{
		[DataMember]
		public int AchievementRankId {get; set;}
		[DataMember]
		public string VisualStyle {get; set;}
	}
}
