using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Gift
{
	[DataContract(Name = "LevelGiftDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Gift")]
	public class LevelGiftDefinition
	{
		[DataMember]
		public int Boost {get; set;}
		[DataMember]
		public int Level {get; set;}
		[DataMember]
		public int LevelGiftId {get; set;}
	}
}
