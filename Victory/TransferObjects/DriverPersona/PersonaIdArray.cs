using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "PersonaIdArray", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class PersonaIdArray
	{
		[DataMember]
		public System.Collections.Generic.List<long> PersonaIds {get; set;}
	}
}
