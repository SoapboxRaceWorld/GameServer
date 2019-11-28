using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "LuckyDrawInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class LuckyDrawInfo
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.LuckyDrawBox> Boxes {get; set;}
		[DataMember]
		public System.String CardDeck {get; set;}
		[DataMember]
		public System.Int32 CurrentStreak {get; set;}
		[DataMember]
		public System.Boolean IsStreakBroken {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.LuckyDrawItem> Items {get; set;}
		[DataMember]
		public System.Int32 NumBoxAnimations {get; set;}
		[DataMember]
		public System.Int32 NumCards {get; set;}
	}
}
