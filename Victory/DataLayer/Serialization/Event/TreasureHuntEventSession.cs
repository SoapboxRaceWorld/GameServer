using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "TreasureHuntEventSession", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class TreasureHuntEventSession
	{
		[DataMember]
		public System.Int32 CoinsCollected {get; set;}
		[DataMember]
		public System.Boolean IsStreakBroken {get; set;}
		[DataMember]
		public System.Int32 NumCoins {get; set;}
		[DataMember]
		public System.Int32 Seed {get; set;}
		[DataMember]
		public System.Int32 Streak {get; set;}
	}
}
