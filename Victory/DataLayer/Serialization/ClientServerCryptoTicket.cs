using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ClientServerCryptoTicket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ClientServerCryptoTicket
	{
		[DataMember]
		public System.String CryptoTicket {get; set;}
		[DataMember]
		public System.String SessionKey {get; set;}
		[DataMember]
		public System.String TicketIv {get; set;}
	}
}
