using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ClientConfigTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ClientConfigTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.ClientConfig> clientConfigs {get; set;}
	}
}
