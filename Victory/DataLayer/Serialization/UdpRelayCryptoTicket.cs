using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "UdpRelayCryptoTicket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class UdpRelayCryptoTicket
	{
		[DataMember]
		public string CryptoTicket {get; set;}
		[DataMember]
		public string SessionKey {get; set;}
		[DataMember]
		public string TicketIv {get; set;}
	}
}
