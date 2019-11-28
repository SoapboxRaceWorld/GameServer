using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "LuckyDrawInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class LuckyDrawInfo
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.LuckyDrawBox> Boxes {get; set;}
		[DataMember]
		public string CardDeck {get; set;}
		[DataMember]
		public int CurrentStreak {get; set;}
		[DataMember]
		public bool IsStreakBroken {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.LuckyDrawItem> Items {get; set;}
		[DataMember]
		public int NumBoxAnimations {get; set;}
		[DataMember]
		public int NumCards {get; set;}
	}
}
