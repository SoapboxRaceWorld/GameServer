using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ClientLog", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ClientLog
	{
		[DataMember]
		public System.DateTime date {get; set;}
		[DataMember]
		public System.String message {get; set;}
	}
}
