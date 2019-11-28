using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "AchievementRewards", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class AchievementRewards
	{
		[DataMember]
		public System.Int32 AchievementRankId {get; set;}
		[DataMember]
		public System.String VisualStyle {get; set;}
	}
}
