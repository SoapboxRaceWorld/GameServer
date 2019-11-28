using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "Reward", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class Reward
	{
		[DataMember]
		public System.Int32 Rep {get; set;}
		[DataMember]
		public System.Int32 Tokens {get; set;}
	}
}
