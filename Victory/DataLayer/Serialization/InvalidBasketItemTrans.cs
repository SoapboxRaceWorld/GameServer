using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InvalidBasketItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InvalidBasketItemTrans
	{
		[DataMember]
		public System.Int32 Index {get; set;}
		[DataMember]
		public System.Int32 Reason {get; set;}
	}
}
