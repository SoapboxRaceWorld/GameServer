using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "RewardPart", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class RewardPart
	{
		[DataMember]
		public System.Int32 RepPart {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Event.enumRewardCategory RewardCategory {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Event.enumRewardType RewardType {get; set;}
		[DataMember]
		public System.Int32 TokenPart {get; set;}
	}
}
