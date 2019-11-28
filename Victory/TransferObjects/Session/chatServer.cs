using System.Runtime.Serialization;
namespace Victory.TransferObjects.Session
{
	[DataContract(Name = "chatServer", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session")]
	public class chatServer
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.TransferObjects.Session.chatRoom> Rooms {get; set;}
		[DataMember]
		public string ip {get; set;}
		[DataMember]
		public int port {get; set;}
		[DataMember]
		public string prefix {get; set;}
	}
}
