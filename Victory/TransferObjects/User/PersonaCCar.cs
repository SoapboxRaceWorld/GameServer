using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "PersonaCCar", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class PersonaCCar
	{
		[DataMember]
		public System.Int32 CCID {get; set;}
		[DataMember]
		public System.Int32 Durability {get; set;}
		[DataMember]
		public System.Single Heat {get; set;}
		[DataMember]
		public System.Boolean IsDefault {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
	}
}
