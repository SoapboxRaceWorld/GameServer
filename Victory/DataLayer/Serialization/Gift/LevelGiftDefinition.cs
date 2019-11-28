using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Gift
{
	[DataContract(Name = "LevelGiftDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Gift")]
	public class LevelGiftDefinition
	{
		[DataMember]
		public System.Int32 Boost {get; set;}
		[DataMember]
		public System.Int32 Level {get; set;}
		[DataMember]
		public System.Int32 LevelGiftId {get; set;}
	}
}
