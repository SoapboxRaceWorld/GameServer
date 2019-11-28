using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ClientServerCryptoTicket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ClientServerCryptoTicket
	{
		[DataMember]
		public string CryptoTicket {get; set;}
		[DataMember]
		public string SessionKey {get; set;}
		[DataMember]
		public string TicketIv {get; set;}
	}
}
