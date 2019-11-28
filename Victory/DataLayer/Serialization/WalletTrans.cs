using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "WalletTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class WalletTrans
	{
		[DataMember]
		public System.Double Balance {get; set;}
		[DataMember]
		public System.String Currency {get; set;}
	}
}
