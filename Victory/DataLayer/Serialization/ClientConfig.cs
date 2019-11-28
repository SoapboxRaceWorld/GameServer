using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ClientConfig", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ClientConfig
	{
		[DataMember]
		public string group {get; set;}
		[DataMember]
		public long level {get; set;}
	}
}
