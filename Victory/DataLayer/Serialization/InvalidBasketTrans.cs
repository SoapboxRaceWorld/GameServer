using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InvalidBasketTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InvalidBasketTrans
	{
		[DataMember]
		public Victory.DataLayer.Serialization.BasketTrans Basket {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.InvalidBasketItemTrans> InvalidItems {get; set;}
	}
}
