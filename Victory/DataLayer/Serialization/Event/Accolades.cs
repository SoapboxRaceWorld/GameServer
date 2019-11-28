using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "Accolades", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class Accolades
	{
		[DataMember]
		public Victory.DataLayer.Serialization.Event.Reward FinalRewards {get; set;}
		[DataMember]
		public bool HasLeveledUp {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Event.LuckyDrawInfo LuckyDrawInfo {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Event.Reward OriginalRewards {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.RewardPart> RewardInfo {get; set;}
	}
}
