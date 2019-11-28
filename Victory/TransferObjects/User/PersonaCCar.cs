using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "PersonaCCar", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class PersonaCCar
	{
		[DataMember]
		public int CCID {get; set;}
		[DataMember]
		public int Durability {get; set;}
		[DataMember]
		public float Heat {get; set;}
		[DataMember]
		public bool IsDefault {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
	}
}
