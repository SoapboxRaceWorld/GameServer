using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "UdpRelayCryptoTicket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class UdpRelayCryptoTicket
	{
		[DataMember]
		public System.String CryptoTicket {get; set;}
		[DataMember]
		public System.String SessionKey {get; set;}
		[DataMember]
		public System.String TicketIv {get; set;}
	}
}
