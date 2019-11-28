using System.Runtime.Serialization;
namespace Victory.TransferObjects.Session
{
	[DataContract(Name = "chatServer", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session")]
	public class chatServer
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.TransferObjects.Session.chatRoom> Rooms {get; set;}
		[DataMember]
		public System.String ip {get; set;}
		[DataMember]
		public System.Int32 port {get; set;}
		[DataMember]
		public System.String prefix {get; set;}
	}
}
