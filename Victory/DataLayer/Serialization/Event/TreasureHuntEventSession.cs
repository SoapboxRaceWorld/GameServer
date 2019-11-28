using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "TreasureHuntEventSession", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class TreasureHuntEventSession
	{
		[DataMember]
		public int CoinsCollected {get; set;}
		[DataMember]
		public bool IsStreakBroken {get; set;}
		[DataMember]
		public int NumCoins {get; set;}
		[DataMember]
		public int Seed {get; set;}
		[DataMember]
		public int Streak {get; set;}
	}
}
