using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "Reward", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class Reward
	{
		[DataMember]
		public int Rep {get; set;}
		[DataMember]
		public int Tokens {get; set;}
	}
}
