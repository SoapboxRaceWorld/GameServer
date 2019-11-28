using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "UserIdArray", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class UserIdArray
	{
		[DataMember]
		public System.Collections.Generic.List<System.Int64> UserIds {get; set;}
	}
}
