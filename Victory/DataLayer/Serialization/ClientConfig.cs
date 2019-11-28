using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ClientConfig", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ClientConfig
	{
		[DataMember]
		public System.String group {get; set;}
		[DataMember]
		public System.Int64 level {get; set;}
	}
}
