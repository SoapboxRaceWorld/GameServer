using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "FriendResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class FriendResult
	{
		[DataMember]
		public Victory.TransferObjects.DriverPersona.FriendPersona persona {get; set;}
		[DataMember]
		public System.Int32 result {get; set;}
	}
}
